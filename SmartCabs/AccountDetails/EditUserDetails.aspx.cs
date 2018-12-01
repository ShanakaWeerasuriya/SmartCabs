using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartCabs.AccountDetails
{
    public partial class EditUserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisableFields();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            enableFields();
        }


        private void enableFields()
        {
            txtUserName.Enabled = true;
            txtConfirmPassword.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword.Enabled = true;
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtFullName.Enabled = true;
            txtMobile.Enabled = true;
            cmbUserType.Enabled = false;
        }

        private void DisableFields()
        {
            txtUserName.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtFullName.Enabled = false;
            txtMobile.Enabled = false;
            cmbUserType.Enabled = false;
        }
    }
}