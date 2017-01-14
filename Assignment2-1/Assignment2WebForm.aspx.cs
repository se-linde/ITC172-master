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
    // string[,] product = new string[5, 2]; // 5 rows - horiz, 2 columns - vert. 

    /* protected void Page_Load(object sender, EventArgs e)
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
         product[4, 0] = "Celery";
         product[4, 1] = "1.99";


         // ProduceCheckBoxList.DataSource = product;
         // ProduceCheckBoxList.DataBind();      

         // This keeps the list from repeating. 
         if (!IsPostBack)
         {
             GetProduce();
         }
     } 
     */

    string[,] shindig = new string[6, 2]; // 6 rows - horiz, 2 columns - vert. 

    protected void Page_Load(object sender, EventArgs e)
    {
        // Here's where the actual array is, inside a method. 
        // Don't use single quotes. 

        // A list of holidays by name and date. 
        // List of holidays: http://www.holidayinsights.com/moreholidays/

        shindig[0, 0] = "Arbor Day"; // 4/28/2017
        shindig[0, 1] = "4/28/2017";  // "0.99" 
        shindig[1, 0] = "National Fritters Day"; // 12/02/2017
        shindig[1, 1] = "12/2/2017"; // "1.99"
        shindig[2, 0] = "Pi Day"; // 03/14/2017
        shindig[2, 1] = "3/14/2017"; // "2.25"
        shindig[3, 0] = "Waffle Day"; //  03/25/2017
        shindig[3, 1] = "3/25/2017"; // "0.99"
        shindig[4, 0] = "May Day"; // 05/01/2017
        shindig[4, 1] = "5/1/2017"; // "1.99"
        shindig[5, 0] = "Loyalty Day"; // 05/01/2017
        shindig[5, 1] = "5/1/2017"; // "1.99"

        // ProduceCheckBoxList.DataSource = product;
        // ProduceCheckBoxList.DataBind();      

        // This keeps the list from repeating. 
        if (!IsPostBack)
        {
            GetShindig();
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

    /* protected void GetProduce()
    {
        for (int i = 0; i < 5; i++)
        {
            ListItem item = new ListItem();
            item.Text = product[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    } */

    protected void GetShindig()
    {
        for (int i = 0; i < 6; i++)
        {
            ListItem item = new ListItem();
            item.Text = shindig[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    }



    protected void TotalButton_Click(object sender, EventArgs e)
    {
        // Can't assign anything in a loop without initializing it outside the loop.
        int counter = 0;
        // double total = 0;
      
        foreach (ListItem item in ProduceCheckBoxList.Items)
        {  // I want to list the dates besides the items when the button is pressed. 
            // This currently doesn't happen. 

            // string productName = shindig[counter, 0];
            DateTime productName = DateTime.Parse(shindig[counter, 0]); 

            if (item.Selected)
            {
                if (item.Text.Equals(productName))
                {
                    // total += double.Parse(shindig[counter, 1]);                 
                    // DateTime date = DateTime.Parse(shindig[counter, 1]);
                
                    ProduceCheckBoxList.Items.Add(item);
                    

                }

            }
            counter++;
        }
        // Label2.Text = "Your Total Is: " date2;
        
    }

}
