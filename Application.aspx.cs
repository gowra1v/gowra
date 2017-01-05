using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12345
{
    public partial class Application : System.Web.UI.Page
    {
        String type; float Rent; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
        }

        protected void oneBedoneBath_Click(object sender, ImageClickEventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 0;

            

        }

        protected void twoBedoneBath_Click(object sender, ImageClickEventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 1;

        }

        protected void twoBedBath_Click(object sender, ImageClickEventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 2;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {   if (RadioButtonList1.SelectedItem.Text == "$800.00/mo. for 6 Months")
            {
                Rent = 800;

            }
            else if (RadioButtonList1.SelectedItem.Text == "$750.00/mo. for 12 Months")
            {
                Rent = 750;

            }
        else if (RadioButtonList1.SelectedItem.Text == "$700.00/mo. for 24 Months")
            {
                Rent = 700;
            }
            Session.Add("Rent", Rent);
            type = "1 Bed 1 Bath";
            Session.Add("Type", type);

                Response.Redirect("~/Registration.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string date = String.Format("{0:MM/dd/yyyy}",Calendar1.SelectedDate);
            
             startDate.Text = date ;
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }



        //protected void Submit_Click(object sender, EventArgs e)
        //{
        //    if (onebedonebathsixmonths.Checked)
        //    {
        //        Rent = 800;

        //    }
        //    else if (onebedonebathoneyear.Checked)
        //    {
        //        Rent = 750;
        //    }
        //    else if (onebedonebathonehalfyear.Checked)
        //    {
        //        Rent = 700;
        //    }

        //}
    }
}