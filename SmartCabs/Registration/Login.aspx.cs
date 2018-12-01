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
    public partial class WebForm4 : System.Web.UI.Page
    {
        LoginControl LOG = new LoginControl();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                cmbUserType.DataSource = LOG.populateUserType();
                cmbUserType.DataValueField = "UserTypeID";
                cmbUserType.DataTextField = "UserType";
                cmbUserType.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LOG.UserName = txtUserName.Text;
            LOG.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text,"SHA1");
            LOG.UserTypeId =Convert.ToInt16(cmbUserType.SelectedValue);
            int result = LOG.Login();

            switch (result)
            {
                case 1:
                    Session["User"] = User;
                    Response.Redirect("~/Home.aspx");
                    return;
                case 2:
                    Session["User"] = User;
                    Response.Redirect("~/Home.aspx");
                    return;
                case 3:
                    Session["User"] = User;
                    Response.Redirect("~/Home.aspx");
                    return;
                case 4:
                    Session["User"] = User;
                    Response.Redirect("~/Home.aspx");
                    return;

                default:
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please Login with valid credentials')", true);
                    break;
            }
        }

    }
}