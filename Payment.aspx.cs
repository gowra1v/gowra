using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Data;

namespace CAMS
{
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Payment(PaymentAmount) values (@PaymentAmount)  ", con);
            cmd.Parameters.AddWithValue("@PaymentAmount", OtherAmountTextBox.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Dashboard.aspx");
        }
    }
}