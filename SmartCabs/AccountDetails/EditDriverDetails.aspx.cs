using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartCabs.AccountDetails
{
    public partial class EditDriverDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
             DisableFields();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            enableFields();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void enableFields()
        {
            txtConfirmPassword.Enabled = true;
            txtPassword.Enabled = true;
            txtDriverName.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtFullName.Enabled = true;
            txtMobile.Enabled = true;
            txtVehicleDesc.Enabled = true;
            txtVehicleNumber.Enabled = true;
            cmbVehicleType.Enabled = true;
        }

        private void DisableFields()
        {
            txtConfirmPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtDriverName.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtFullName.Enabled = false;
            txtMobile.Enabled = false;
            txtVehicleDesc.Enabled = false;
            txtVehicleNumber.Enabled = false;
            cmbVehicleType.Enabled = false;
          }
    }
}