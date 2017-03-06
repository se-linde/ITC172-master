using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        CAServiceReference.CAServiceClient cas = new CAServiceReference.CAServiceClient();
        int key = cas.PersonLogin(UsernameTextBox.Text, PasswordTextBox.Text); 
        if(key != 0)
        {
            Session["userkey"] = key;
            Response.Redirect("GrantPage.aspx"); 

        } else
        {
            Resultlabel.Text = "Login Failed!"; 
        }
            

    }
}