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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into UserDetails (FirstName,LastName,MiddleName,Email,Phone) values(@FirstName,@LastName,@MiddleName,@Email,@Phone)", con);
            try
            {
               
                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", MiddleName.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                SqlCommand cmd1 = new SqlCommand("Select UserID from UserDetails where phone = '" + Phone.Text + "'", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                DataTable data = new DataTable();
                adp.Fill(data);
                if (data.Rows.Count > 0)
                {
                    string ID = data.Rows[0][0].ToString();
                    int UserID = int.Parse(ID);
                    string aptype = Session["type"].ToString();
                    string rent = Session["rent"].ToString();
                    int TotalRent = int.Parse(rent);
                    SqlCommand cmd2 = new SqlCommand("insert into Application(userId,AptType,Rent,Status) values(@userId,@AptType,@Rent,@Status)", con);

                    cmd2.Parameters.AddWithValue("@userId", UserID);
                    cmd2.Parameters.AddWithValue("@AptType", aptype);
                    cmd2.Parameters.AddWithValue("@Rent", TotalRent);
                    cmd2.Parameters.AddWithValue("@Status", "Pending");
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Insert is successfull')", true);
                    Response.Redirect("Default.aspx");



                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

        
    }
}