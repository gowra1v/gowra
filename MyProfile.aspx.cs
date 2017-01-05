using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAMS
{
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Edit_Click(object sender, EventArgs e)
        {
            UserName.Enabled = true;
            FirstName.Enabled = true;
            MiddleName.Enabled = true;
            LastName.Enabled = true;
            Email.Enabled = true;
            Phone.Enabled = true;
            Save.Visible = true;
            Edit.Visible = false;
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            UserName.Enabled = false;
            FirstName.Enabled = false;
            MiddleName.Enabled = false;
            LastName.Enabled = false;
            Email.Enabled = false;
            Phone.Enabled = false;
            Edit.Visible = true;
            Save.Visible = false;
        }
    }
}