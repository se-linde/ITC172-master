using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Email: lmann@gmail.com
// Password: MannPass


// user; ozzy@gmail.com
// password: password

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities cae = new Community_AssistEntities();

        int result = cae.usp_Login(UserNameTextBox.Text, PasswordTextBox.Text); 

        if (result != -1)
        {
            var key = (from p in cae.People
                       where p.PersonEmail.Equals(UserNameTextBox.Text)
                       select p.PersonKey).FirstOrDefault(); // This is LINQ. 

            int pKey = (int)key;

            Session["userKey"] = key;
            Response.Redirect("Donate.aspx"); 
        } else
        {
            Errorlabel.Text = "Whoa! Invalid Login!"; 
        }

    }
}