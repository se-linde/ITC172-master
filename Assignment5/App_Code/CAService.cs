using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAService" in code, svc and config file together.
public class CAService : ICAService
{

    Community_AssistEntities cae = new Community_AssistEntities(); 

    public bool ApplyForGrant(GrantRequest gr)
    {
        bool result = true;

        try
        {
            // GrantReview review = new GrantReview();
            // review.GrantRequest = gr; 
            // review.GrantRequestStatus = "pending";
            cae.GrantRequests.Add(gr);
            // cae.GrantReviews.Add(review);
            cae.SaveChanges();
        }

        catch(Exception ex)
        {
            result = false;
            throw ex;
        }

        return result; 

    }

    public List<GrantInfo> GetGrantsByPerson(int personId) // was GetGrantsByperson
    {
        var grants = from g in cae.GrantRequests
                     from r in g.GrantReviews
                     where g.PersonKey == personId
                     select new
                     {
                         g.GrantRequestDate,
                         g.GrantRequestExplanation,
                         g.GrantType.GrantTypeName,
                         g.GrantRequestAmount,
                         r.GrantRequestStatus
                     };
        List<GrantInfo> info = new List<GrantInfo>(); 
        foreach (var gr in grants)
        {
            GrantInfo gi = new GrantInfo();
            gi.GrantTypeName = gr.GrantTypeName; // was granttypesomethingelse
            gi.Explanation = gr.GrantRequestExplanation;
            gi.Amount = (decimal)gr.GrantRequestAmount;
            gi.Status = gr.GrantRequestStatus;

            info.Add(gi); 

        }

        return info; 

    }

    public List<GrantType> GetGrantTypes() // list is like an array, and is a generic. Give it a type at runtime. 
    {

        var types = from g in cae.GrantTypes
                     select new
                     {
                         g.GrantTypeKey,
                         g.GrantTypeName
                     };
        List<GrantType> gTypes = new List<GrantType>(); 

        foreach(var t in types)
        {
            GrantType type = new GrantType();
            type.GrantTypeKey = t.GrantTypeKey; 
            type.GrantTypeName = t.GrantTypeName;
            gTypes.Add(type);  
        }

        return gTypes;  
    }

    public int PersonLogin(string user, string password)
    {
        int key = 0; 
        int result = cae.usp_Login(user, password); 
        if (result != -1)
        {
            var uKey = (from p in cae.People
                       where p.PersonEmail.Equals(user)
                       select p.PersonKey).FirstOrDefault();

            key = (int)uKey; 
        }

        return key; 
    }

    public bool RegisterPerson(PersonLite p)
    {
        bool result = true;

        int success = cae.usp_Register(p.LastName, p.FirstName, p.Email,
            p.Password, p.Apartment, p.Street, p.City, p.State,
            p.Zipcode, p.HomePhone, p.WorkPhone);

        if (success == -1) // Doesn't have to have brackets if there's only one line/statement. 
            result = false; 

        return result;

    }
}
