using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;

namespace CAMS
{
    public partial class Applications : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ApplicationID,(FirstName + LastName) as Name,Email,Phone,AptType,Rent,Status from UserDetails,Application where UserDetails.userId = Application.userId and Application.Status = 'Pending' ;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Pending.DataSource = dt;
                Pending.DataBind();
                con.Close();
            }
        }

        protected void Pending_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Approve_Click(object sender, EventArgs e)
        {
            string Uid = string.Empty;
            string Aptid = string.Empty;
            foreach (GridViewRow row in Pending.Rows)
        {
            CheckBox cb = (CheckBox)row.FindControl("Check");
            if (cb != null && cb.Checked)
            {
                
                    con.Open();
                          SqlCommand cmd = new SqlCommand("Update Application set status = 'Approve' where ApplicationId = ' " + Pending.DataKeys[row.RowIndex].Value  + "'", con);
                            cmd.ExecuteNonQuery();
                    SqlCommand cm = new SqlCommand("SELECT userId from Application where ApplicationId = '" + Pending.DataKeys[row.RowIndex].Value + "'", con);

                    SqlDataReader UserID = null;
                   

                    UserID = cm.ExecuteReader();

                    while (UserID.Read())
                    {
                        Uid = Convert.ToString(UserID["userId"]);
                    }
                    con.Close();
                }
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT ApartmentId from Apartment where blockID='"+Block.SelectedItem.Value+"' and AptNumber='"+AvailApartment.SelectedItem.Value+"'", con);

            SqlDataReader ApartmentID = null;
            

            ApartmentID = cmd1.ExecuteReader();

            while (ApartmentID.Read())
            {
                Aptid = Convert.ToString(ApartmentID["ApartmentId"]);
            }



            SqlCommand cmd2 = new SqlCommand("insert into Lease(StartDate,EndDate,SecurityDeposit,UserId,ApartmentId) values(@StartDate,@EndDate,@SecurityDeposit,@UserId,@ApartmentId)", con);

            int ID = Convert.ToInt16(Uid);
            int AID = Convert.ToInt16(Aptid);
            cmd2.Parameters.AddWithValue("@StartDate","");
            cmd2.Parameters.AddWithValue("@EndDate","");
            cmd2.Parameters.AddWithValue("@SecurityDeposit",1000);
            cmd2.Parameters.AddWithValue("@UserId",ID);
            cmd2.Parameters.AddWithValue("@ApartmentId",AID);
            con.Close();
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            SmtpClient smtpServer = new SmtpClient();

            MailMessage mail = new MailMessage();
            smtpServer.Credentials = new System.Net.NetworkCredential("vamsi.vf406@gmail.com", "gowra1991");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            smtpServer.EnableSsl = true;
            string mobile;
            mail.From = new MailAddress("vamsi.vf406@gmail.com", "Canterbury Apartments");
            mail.To.Add("gowra1v@cmich.edu");

            mail.Subject = "Test";
            mail.Body = "Hello";
            mobile = "6096475141" + "@vtext.com";
            mail.To.Add(mobile);
            smtpServer.Send(mail);
        }

        protected void Reject_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in Pending.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("Check");
                if (cb != null && cb.Checked)
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Application set status = 'Reject' where ApplicationId = ' " + Pending.DataKeys[row.RowIndex].Value + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status.SelectedItem.Value == "Approve")
            {
                Approve.Visible = false;
                Reject.Visible = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ApplicationID,(FirstName + LastName) as Name,Email,Phone,AptType,Rent,Status from UserDetails,Application where UserDetails.userId = Application.userId and Application.Status = 'Approve' ;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Pending.DataSource = dt;
                Pending.DataBind();
                con.Close();
            }else if (status.SelectedItem.Value == "Pending")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ApplicationID,(FirstName + LastName) as Name,Email,Phone,AptType,Rent,Status from UserDetails,Application where UserDetails.userId = Application.userId and Application.Status = 'Pending' ;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Pending.DataSource = dt;
                Pending.DataBind();
                con.Close();
            }



        }

        protected void Mail_Click(object sender, EventArgs e)
        {
            SmtpClient smtpServer = new SmtpClient();

            MailMessage mail = new MailMessage();
             smtpServer.Credentials = new System.Net.NetworkCredential("vamsi.vf406@gmail.com", "gowra1991");
            smtpServer.Port = 587;
            smtpServer.Host = "smtp.gmail.com";
            smtpServer.EnableSsl = true;
            string mobile;
            mail.From = new MailAddress("vamsi.vf406@gmail.com", "Canterbury Apartments");
            mail.To.Add("gowra1v@cmich.edu");

            mail.Subject = "Test";
            mail.Body = "Hello";
            mobile = "6096475141" + "@vtext.com";
            mail.To.Add(mobile);
            smtpServer.Send(mail);
        }

        protected void Block_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            String sqlstatement = "select AptNumber form Apartment where blockID= '" + Block.SelectedItem.Value + "' and Type = '" + ApartType.SelectedItem.Value + "'";
            SqlCommand sqlcmd = new SqlCommand(sqlstatement, con);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AvailApartment.DataSource = dt;


                AvailApartment.DataTextField = "AptNumber"; // the items to be displayed in the list items

                AvailApartment.DataBind();
            }




        }

        protected void Check_Availability_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            String sqlstatement = "select AptNumber from Apartment where blockID= '" + Block.SelectedItem.Value + "' and Type = '" + ApartType.SelectedItem.Value + "'";
            SqlCommand sqlcmd = new SqlCommand(sqlstatement, con);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            sqlda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AvailApartment.DataSource = dt;


                AvailApartment.DataTextField = "AptNumber"; // the items to be displayed in the list items

                AvailApartment.DataBind();
            }
        }
    }

    //protected void Pending_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "approve")
    //    {
    //        string ID = Pending.SelectedRow.Cells[0].Text;
    //        con.Open();
    //        SqlCommand cmd = new SqlCommand("Update Application set status = 'Approve' where ApplicationId = ID )", con);
    //        cmd.ExecuteNonQuery();
    //        con.Close();

    //    }
    //    else if (e.CommandName == "reject")
    //    {
    //        con.Open();
    //        SqlCommand cmd = new SqlCommand("Update Application set status = 'Reject' where ApplicationId = '"+e.CommandName+"' ",con);
    //        cmd.ExecuteNonQuery();
    //        con.Close();
    //    }
}
    
