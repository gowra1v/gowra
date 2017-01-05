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
    public partial class ServiceRequest : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string AptID = string.Empty;
            String user = Session["Uid"].ToString();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select ApartmentId from Lease where userId = '" + user+ "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
            DataTable data1 = new DataTable();
            adp.Fill(data1);
            SqlDataReader Aptid = null;


            Aptid = cmd2.ExecuteReader();

            while (Aptid.Read())
            {
                AptID = Convert.ToString(Aptid["ApartmentId"]);
            }
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Maintenance(MaintenanceDate,MaintenanceType,Description,ApartmentId,Status) values (@MaintenanceDate,@MaintenanceType,@Description,@ApartmentId,@Status) ", con);
            cmd.Parameters.AddWithValue("@MaintenanceType", Servicetype.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Description",detail.InnerText);
            cmd.Parameters.AddWithValue("@MaintenanceDate",DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@ApartmentId", AptID);
            cmd.Parameters.AddWithValue("@Status","Open");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        

        protected void Maintainence_Click(object sender, EventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 0;
        }

        protected void Lease_Termination_Click(object sender, EventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 1;
        }

        protected void Lease_Extenion_Click(object sender, EventArgs e)
        {
            LeaseTerm.ActiveViewIndex = 2;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string date = String.Format("{0:MM/dd/yyyy}", Calendar1.SelectedDate);

            startDate.Text = date;
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Termination_Click(object sender, EventArgs e)
        {
            string LeaseID = string.Empty;
            String user = Session["Uid"].ToString();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select LeaseId from Lease where userId = '" + user + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
            DataTable data1 = new DataTable();
            adp.Fill(data1);
            SqlDataReader Aptid = null;


            Aptid = cmd2.ExecuteReader();

            while (Aptid.Read())
            {
                LeaseID = Convert.ToString(Aptid["LeaseId"]);
            }
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Termination (LeavingDate,LeavingReason,LeaseId) values(@LeavingDate,@LeavingReason,@LeaseId) ", con);
            cmd.Parameters.AddWithValue("@LeavingDate",startDate.Text);
            cmd.Parameters.AddWithValue("@LeavingReason", reason.InnerText);
            cmd.Parameters.AddWithValue("@LeaseId", LeaseID);
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void TermSubmit_Click(object sender, EventArgs e)
        {

            string LeaseID = string.Empty;
            String user = Session["Uid"].ToString();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select LeaseId from Lease where userId = '" + user + "'", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
            DataTable data1 = new DataTable();
            adp.Fill(data1);
            SqlDataReader Aptid = null;


            Aptid = cmd2.ExecuteReader();

            while (Aptid.Read())
            {
                LeaseID = Convert.ToString(Aptid["LeaseId"]);
            }
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Renewal(RenewalPeriod,LeaseId) values (@RenewalPeriod,@LeaseId) ", con);
            cmd.Parameters.AddWithValue("@RenewalPeriod",term.SelectedItem.Text);
            
            cmd.Parameters.AddWithValue("@LeaseId", LeaseID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}