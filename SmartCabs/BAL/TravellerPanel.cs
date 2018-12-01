using SmartCabs.AccountDetails;
using SmartCabs.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SmartCabs.BAL
{
    public class TravellerPanel
    {
        DataAccessLayer DAL = new DataAccessLayer();


        private string travellerName;
        private string password;
        private string fullName;
        private string emailId;
        private string mobile;

        public string TravellerName
        {
            get { return travellerName; }
            set { travellerName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }


        public bool CreateTraveller()
        {

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@TravellerName",
                    Value=TravellerName
                },

                new SqlParameter()
                {
                    ParameterName="@Password",
                    Value=Password
                },

                 new SqlParameter()
                {
                    ParameterName="@FullName",
                    Value=FullName
                },

                  new SqlParameter()
                {
                    ParameterName="@EmailID",
                    Value=EmailId
                },

                    new SqlParameter()
                {
                    ParameterName="@Mobile",
                    Value=Mobile
                },
            };


            return DAL.spExecuteWithReturnValue("spInsertTraveller", param);
        }


        public DataTable populateUserTypeID()
        {

            DataTable dt = new DataTable();


            dt = DAL.PopulateDropDown("SELECT UserTypeId FROM Traveller");
            return dt;
        }


        public DataTable populateTravellersDataGrid()
        {
            return DAL.executeCommandWithReturnDataTable("SELECT * FROM Traveller");

        }

        public bool UpdateTraveller(TravellerDetails details,GridViewUpdateEventArgs e)
        {

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@CustomerName",
                    Value= (details.gvEditorDelete.Rows[e.RowIndex].FindControl("txtTravellerName") as TextBox).Text.Trim()
                },
                new SqlParameter()
                {
                    ParameterName="@FullName",
                    Value= (details.gvEditorDelete.Rows[e.RowIndex].FindControl("txtFullName") as TextBox).Text.Trim()
                },
                new SqlParameter()
                {
                    ParameterName="@Mobile",
                    Value= (details.gvEditorDelete.Rows[e.RowIndex].FindControl("txtMobile") as TextBox).Text.Trim()
                },
                new SqlParameter()
                {
                    ParameterName="@EmailID",
                    Value= (details.gvEditorDelete.Rows[e.RowIndex].FindControl("txtEmailID") as TextBox).Text.Trim()
                },

                 new SqlParameter()
                {
                    ParameterName="@UserTypeId",
                    Value= (details.gvEditorDelete.Rows[e.RowIndex].FindControl("cmbUserType") as DropDownList).SelectedValue.ToString().Trim()
                },

                 new SqlParameter()
                 { 
                     ParameterName = "@CustomerID",
                     Value = (Convert.ToInt32(details.gvEditorDelete.DataKeys[e.RowIndex].Value.ToString()))
                 }
                 
            };

            return Convert.ToBoolean(DAL.spExecuteWithReturnValue("spUpdateTravellerDetails", param));



        }
    }
}