using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; // general data tools. 
using System.Data.SqlClient; // SQL Server data tools. 
using System.Configuration; // Tools for talking to the config file.


/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{
    SqlConnection connect;
    string user;
    string pass; 


    public LoginClass(string username, string password)
    {
        user = username;
        pass = password;
        string connectString = 
            ConfigurationManager.ConnectionStrings["BookReviewConnection"].ToString();
        connect = new SqlConnection(connectString); 
    }

    public int ValidateLogin()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connect;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_ReviewerLogin";

        cmd.Parameters.AddWithValue("@ReviewerUserName", user);

        cmd.Parameters.AddWithValue("@ReviewerPassword", pass);

        connect.Open();
        int result = cmd.ExecuteNonQuery();
        connect.Close();

        int key = 0; 

        if (result != -1) // -1 means it failed; didn't return results. 
        {
            key = GetUserkey();
        }

        return key; 

    }

    private int GetUserkey()
    {
        string sql = "Select ReviewerKey from reviewer where ReviewerUsername = @user";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@user", user);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();

        int key = 0; 

        while (reader.Read())
        {
            key = (int)reader["ReviewerKey"];
        }

        connect.Close();
        return key; 

    }
}