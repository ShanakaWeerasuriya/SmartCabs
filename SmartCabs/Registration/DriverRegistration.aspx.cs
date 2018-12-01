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
    public partial class WebForm2 : System.Web.UI.Page
    {
        DriverPanel driver = new DriverPanel();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                cmbVehicleType.DataSource = driver.populateVehicleType();
                cmbVehicleType.DataTextField = "VehicleType";
                cmbVehicleType.DataValueField = "VehicleTypeID";
                cmbVehicleType.DataBind();


            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            driver.DriverName = txtDriverName.Text;
            driver.FullName = txtFullName.Text;
            driver.Mobile = txtMobile.Text;
            driver.EmailId = txtEmail.Text;
            driver.VehicleTypeId = Convert.ToInt16(cmbVehicleType.SelectedValue);
            driver.VehicleNumber = txtVehicleNumber.Text;
            driver.VehicleDescription = txtVehicleDesc.Text;
            string password = txtPassword.Text;
            driver.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            if (driver.CreateDriver())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);

                SendEmail email = new SendEmail();
                email.SendPasswordResetEmail(driver.EmailId, driver.DriverName, password,driver.FullName);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Insertion Failed')", true);
            }
        }
    }
}