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
    public partial class WebForm1 : System.Web.UI.Page
    {
        RegisterUserPanel user = new RegisterUserPanel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                cmbUserType.DataSource = user.populateUserType();
                cmbUserType.DataTextField = "UserType";
                cmbUserType.DataValueField = "UserTypeID";
                cmbUserType.DataBind();


            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
                user.UserName = txtUserName.Text;
                user.FullName = txtFullName.Text;
                user.Mobile = txtMobile.Text;
                user.EmailId = txtEmail.Text;
                user.UserTypeId = Convert.ToInt16(cmbUserType.SelectedValue);
                user.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtConfirmPassword.Text, "SHA1");

                if (user.CreateUser())
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Insertion Failed')", true);
                }
                

                
            


        }
    }
}