using SmartCabs.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartCabs.Registration
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        TravellerPanel traveller = new TravellerPanel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            traveller.TravellerName = txtTravellerName.Text;
            traveller.FullName = txtFullName.Text;
            traveller.Mobile = txtMobile.Text;
            traveller.EmailId = txtEmail.Text;
            string Password = txtPassword.Text;
            traveller.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");

            if (traveller.CreateTraveller())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                SendEmail email = new SendEmail();
                email.SendPasswordResetEmail(traveller.EmailId, traveller.TravellerName, Password, traveller.FullName);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Insertion Failed')", true);
            }
        }

        
    }
}