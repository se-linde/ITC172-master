using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGrid(); 
    }

    protected void FillGrid()
    {
        CAService cas = new CAService();
        DataTable table = cas.GetGrantTypes();
        GridView1.DataSource = table;
        GridView1.DataBind(); 

    }
}