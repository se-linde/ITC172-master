using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; 

public partial class GrantRequest : System.Web.UI.Page
{

    AppClass ac = new AppClass(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserKey"] != null)
        {
            if (!IsPostBack)
            {
                DataTable table = ac.GetGrantTitles();
                DropDownList1.DataSource = table;
                DropDownList1.DataTextField = "GrantTypeName";
                DropDownList1.DataValueField = "GrantTypeKey";
                DropDownList1.DataBind();
                ListItem item = new ListItem("Choose a grant:");
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
        if (!DropDownList1.SelectedItem.Text.Equals("Choose a grant:"))
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = ac.GetGrants(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind(); 
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }

}