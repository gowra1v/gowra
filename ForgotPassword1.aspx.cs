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
using System.Net.Mail;

namespace CAMS
{
    public partial class ForgotPassword1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string Uid = string.Empty;
            SqlCommand cmd1 = new SqlCommand("Select userId from UserDetails where Email = '" + Email.Text + "'", con);
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
                string password = string.Empty;
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Select Password from Login where userId ='"+ Uid + "'", con);
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd2);
                DataTable data1 = new DataTable();
                adp1.Fill(data1);
                SqlDataReader pass = null;


                pass = cmd2.ExecuteReader();

                while (pass.Read())
                {
                    password = Convert.ToString(pass["Password"]);
                }

                SmtpClient smtpServer = new SmtpClient();

                MailMessage mail = new MailMessage();
                smtpServer.Credentials = new System.Net.NetworkCredential("vamsi.vf406@gmail.com", "gowra1991");
                smtpServer.Port = 587;
                smtpServer.Host = "smtp.gmail.com";
                smtpServer.EnableSsl = true;
                //string mobile;
                mail.From = new MailAddress("vamsi.vf406@gmail.com", "Canterbury Apartments");
                mail.To.Add(Email.Text);

                mail.Subject = "Password";
                mail.Body = "Your Password is" + password;

                Response.Redirect("LoginForm.aspx");
                smtpServer.Send(mail);
                Session.Add("userid", Uid);
                con.Close();
            }
        }

    }
    }
