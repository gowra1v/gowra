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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            string Uid = string.Empty;
            SqlCommand cmd1 = new SqlCommand("Select userId from UserDetails where phone = '" + Phone.Text + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable data = new DataTable();
            adp.Fill(data);
            SqlDataReader UserID = null;


            UserID = cmd1.ExecuteReader();
            
            while (UserID.Read())
            {
                Uid = Convert.ToString(UserID["userId"]);
            }

            Session.Add("userid", Uid);
            con.Close();
            if (data.Rows.Count > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Login(userId,UserName,Password) values (@userId,@UserName,@Password)", con);
                cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.Parameters.AddWithValue("@userId", Uid);

                
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}