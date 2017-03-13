using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/* Test Data: 
 * user: maryg
 * pass: marypassword 
 * */ 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        // Initialize the login class, and pass it the user and password. 
        LoginClass lc = new LoginClass(UserTextBox.Text, PasswordTextBox.Text);
        int key = lc.ValidateLogin(); // Call the validation method. 
        if (key != 0)
        {
            Resultlabel.Text = "Welcome! Correct login!";
            Session["userkey"] = key;
            Response.Redirect("GrantRequestBooks.aspx");
        }
        else
        {
            Resultlabel.Text = "Invalid Login!"; 
        }

    }
}