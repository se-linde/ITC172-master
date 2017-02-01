using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; // General data tools. 
using System.Data.SqlClient; // SQL Server data tools. 
using System.Configuration;  // Tools for talking to the config file. 

/// <summary>
/// Summary description for LoginClass
/// </summary>
/// 

// sample data: 
// email: dthompson@msn.com

// password: ThompsonPass

// password hash: 0xD679C19CD0C8B22F6B0658459A6865EC3767313A5480BE655C002AD08F5AAA913A5856766675A3881F05FB2AF1FD379D2A3CF797058B3ECDF13C59C1099F0CD7

// BYesler@gmail.com
// YeslerPass

public class LoginClass
{

    SqlConnection connect;
    string user;
    string pass;

    public LoginClass(string username, string password)
    {

        user = username;
        pass = password;
        string connectString = ConfigurationManager.ConnectionStrings["CommunityConnection"].ToString();
        connect = new SqlConnection(connectString);
    }

       public int ValidateLogin()
           {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Login";

            cmd.Parameters.AddWithValue("@Email", user);
            cmd.Parameters.AddWithValue("@password", pass);

            connect.Open();
            int result = cmd.ExecuteNonQuery();
            connect.Close();

            int key = 0;

            if (result != -1)
        {
            key = GetUserkey(); 
        }
        return key; 
    }



        private int GetUserkey()
        {
        string sql = "Select PersonKey from Person where PersonEmail = @Email";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Email", user);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();

        int key = 0; 

        while (reader.Read())
        {
            key = (int)reader["PersonKey"]; 
        }

        connect.Close();
        return key; 
         
        }

    }

