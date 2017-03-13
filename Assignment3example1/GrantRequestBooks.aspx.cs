using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; 

public partial class GrantRequestBooks : System.Web.UI.Page
{

    BooksClass bc = new BooksClass(); 
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userkey"] != null) {

           if (!IsPostBack)
            {
                DataTable table = bc.GetAuthors();
                DropDownList1.DataSource = table;
                DropDownList1.DataTextField = "AuthorName";
                DropDownList1.DataValueField = "AuthorKey";
                DropDownList1.DataBind();
                ListItem item = new ListItem("Choose an author.");
                DropDownList1.Items.Insert(0, item); 

            }
        }

        else
        {
            Response.Redirect("Default.aspx"); 
        }

    }

    protected void FillGrid()
    {

        if (!DropDownList1.SelectedItem.Text.Equals("Choose an author."))
        {

            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = bc.GetBooks(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
        }
    }




    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid(); 
    }
}