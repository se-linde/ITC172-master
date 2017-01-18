using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{


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

    }



    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        ShindigDisplay.Text = Calendar1.SelectedDate.ToShortDateString();
        ShindigNo.Text = "There is no shindig on this date."; 

        GetShindig();
    }

    protected void GetShindig()
    {
        for (int i = 0; i < 6; i++)
        {
            if (Calendar1.SelectedDate.ToShortDateString() == shindig[i, 1])
            {
                ShindigDisplay.Text += " " + shindig[i, 0];
            }
            else
            {
                ShindigNo.Text += ""; 
            }

        }

    }

}
    

    
