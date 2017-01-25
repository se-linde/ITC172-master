using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 
 

/// <summary>
/// Summary description for CAService
/// </summary>
public class CAService
{
    // Declaring the SQLConnection Object.
    // It's a built in class. 
    SqlConnection connect; 


    public CAService()
    {
        string connectString = ConfigurationManager.ConnectionStrings["CAConnection"].ToString();
        connect = new SqlConnection(connectString); 

    }

    public DataTable GetGrantTypes()
    {
        DataTable table = new DataTable();

        // SQL Query. 

        string sql = "Select * from GrantType";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;

        // If you have a problem with your connection, this is where it'll fail. 
        connect.Open();

        // This is where it processes the SQL string.
        // Can have an error here; it'd be an error in the SQL.
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connect.Close(); 
        return table; 

    }
}