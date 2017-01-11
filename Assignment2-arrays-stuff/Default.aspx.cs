using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    // This is different than in Java.
    // Declare it here, class level. 
    string[,] product = new string[5, 2]; // 5 rows - horiz, 2 columns - vert. 

    protected void Page_Load(object sender, EventArgs e)
    {
        // Here's where the actual array is, inside a method. 
        // Don't use single quotes. 
        product[0, 0] = "Lettuce"; // Lettuce make an array! 
        product[0, 1] = "0.99";
        product[1, 0] = "Carrots";
        product[1, 1] = "1.99";
        product[2, 0] = "Eggplant";
        product[2, 1] = "2.25";
        product[3, 0] = "Kiwi";
        product[3, 1] = "0.99";
        product[4, 0] = "Tomatoes";
        product[4, 1] = "2.99";


        // ProduceCheckBoxList.DataSource = product;
        // ProduceCheckBoxList.DataBind();      

        // This keeps the list from repeating. 
        if (!IsPostBack)
        {
            GetProduce();
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {   // comparing as Strings. Want to use this for looping through the array.
        //string birthday = "5/9/2017";
        //string inauguration = "1/20/2017";

        DateTime birthday = DateTime.Parse("5/9/2017");
        DateTime inauguration = DateTime.Parse("1/20/2017");

        Label1.Text = "Here is the selected date: " + Calendar1.SelectedDate.ToShortDateString();

        /* if (Calendar1.SelectedDate.ToShortDateString().Equals(birthday))
        {
            Label1.Text += " Happy Birthday!!!"; 
        }
        else if (Calendar1.SelectedDate.ToShortDateString().Equals(inauguration))
        {
            Label1.Text += " Fight the Power!!!";
        } */

        if (Calendar1.SelectedDate == birthday)
        {
            Label1.Text += " Happy parse Birthday!!";
        }

        else if (Calendar1.SelectedDate == inauguration)
        {
            Label1.Text += " NO.";
        }
    }

    protected void GetProduce()
    {
        for (int i = 0; i < 5; i++)
        {
            ListItem item = new ListItem();
            item.Text = product[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    }


    protected void TotalButton_Click(object sender, EventArgs e)
    {
        // Can't assign anything in a loop without initializing it outside the loop.
        int counter = 0;
        double total = 0;
        foreach (ListItem item in ProduceCheckBoxList.Items)
        {
            string productName = product[counter, 0];
            if (item.Selected)
            {
                if (item.Text.Equals(productName))
                {
                    total += double.Parse(product[counter, 1]);
                }
                
            }
            counter++;
        }
        Label2.Text = "Your Total Is: " + total.ToString("C");
    }
}
