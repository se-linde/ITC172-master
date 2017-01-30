using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// call some libraries up here. 
using System.Data;
using System.Data.SqlClient; 
using System.Configuration;


/// <summary>
/// Summary description for BooksClass
/// </summary>
public class BooksClass
{

    private SqlConnection connect; 
        public BooksClass()
        {

        string connectString = ConfigurationManager.ConnectionStrings["BookReviewConnection"].ToString();
        connect = new SqlConnection(connectString);

        }

    public DataTable GetBooks(int authorKey)
    {
        DataTable table = new DataTable();
        string sql = "Select * from Book inner Join AuthorBook " + 
            "on Book.BookKey = AuthorBook.BookKey " + 
            "where AuthorKey = @author";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@author", authorKey);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);

        reader.Close();
        connect.Close();
        return table; 

    }

    public DataTable GetAuthors()
    {
        DataTable table = new DataTable();
        string sql = "Select Authorkey,AuthorName From Author";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);

        reader.Close();
        connect.Close();
        return table;
    }

}