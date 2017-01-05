using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using System.Data;

namespace WebApplication12345
{
    public partial class ApplyForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Block.Name as Block_Name,Apartment.AptNumber,Apartment.IsAvailable,Apartment.Rentalfee,Apartment.Type from Block,Apartment where Block.blockId = Apartment.blockID ", con);
            try
            {

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                dt.Load(sdr);
                Availablehomes.DataSource = dt;
                Availablehomes.DataBind();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        protected void Availablehomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        protected void Availablehomes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "Select")
            //{ 
            //    Int16 num = Convert.ToInt16(e.CommandArgument);
            //    type.Text = Availablehomes.Rows[num].Cells[6].Text;
            //}
        }

        
    }
}