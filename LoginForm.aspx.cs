using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace WebApplication12345
{
    public partial class LoginForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn_Click(object sender, EventArgs e)

        {
            string user, pass;
            user = "admin";
            pass = "admin";
            if (UserNameText.Text == user && Password.Text == pass)
            {
                Response.Redirect("Applications.aspx");
            }
            else
            {
                string name = UserNameText.Text;
                Session.Add("Name", name);
                SqlCommand cmd = new SqlCommand("Select LoginID from Login where UserName = '" + UserNameText.Text + "'  ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Response.Write("<script>alert('User Login Successful')</script>");
                    Response.Redirect("Dashboard.aspx");


                }
                else
                {

                }
            }
        }
    }
}