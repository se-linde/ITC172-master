using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the firat draw of the page, do this. But don't redraw the page. 
        if (!IsPostBack)

        {
            string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other" };
            TipPercentsRadioButtonList.DataSource = tipPercent;
            TipPercentsRadioButtonList.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        Tip tip = new Tip(); 
        tip.MealAmount = double.Parse(MealTextBox.Text);
        if (OtherTextBox.Text == "")
        {
            tip.TipPercent = 0;
            foreach (ListItem item in TipPercentsRadioButtonList.Items)
                    {
               
                    if (item.Selected)
                        {
                        if (item.Text.Equals("Ten Percent"))
                        {
                            tip.TipPercent = 0.1;
                        }
                        else if (item.Text.Equals("Fifteen Percent"))
                        {
                            tip.TipPercent = 0.15;
                        }
                        else if (item.Text.Equals("Twenty Percent"))
                        {
                            tip.TipPercent = 0.2;
                        }
                        else
                        {
                            tip.TipPercent = 0;
                        }

                    }// end foreach
                }// end outer if     
        }// end outer if 
        else
        {
            // Converting the tip percentage into an actual 
            // percentage for calculation. 
            tip.TipPercent = double.Parse(OtherTextBox.Text) / 100;
        }

        ResultLabel.Text = "Amount: " + tip.MealAmount.ToString() + "<br/>" +
            "Tip :" + tip.CalculateTip().ToString("$#.##0.00") + "<br/>" +
            "Tax: " + tip.CalculateTax().ToString("$#.##0.00") + "<br/>" +
            "Total: " + tip.CalculateTotal().ToString("$#.##0.00"); 



    }

}