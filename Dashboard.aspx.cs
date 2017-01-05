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
    
    public partial class Dashboard : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string Uid = string.Empty;
            //string user = Session["userid"].ToString();
            string name = Session["Name"].ToString();
            SqlCommand cmd1 = new SqlCommand("Select userID from Login where UserName = '"+name+"'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable data = new DataTable();
            adp.Fill(data);
            SqlDataReader UserID = null;


            UserID = cmd1.ExecuteReader();

            while (UserID.Read())
            {
                Uid = Convert.ToString(UserID["userID"]);
            }
            Session.Add("Uid", Uid);
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select FirstName from UserDetails where userId = '" + Uid+"'", con);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd2);
            DataTable data1 = new DataTable();
            adp.Fill(data1);
            SqlDataReader UserName = null;


            UserName = cmd2.ExecuteReader();

            while (UserName.Read())
            {
                Name.Text = Convert.ToString(UserName["FirstName"]);
            }
            con.Close();
        }

        protected void Service_Click(object sender, EventArgs e)
        {
            Response.Redirect("Service.aspx");
        }
    }
}