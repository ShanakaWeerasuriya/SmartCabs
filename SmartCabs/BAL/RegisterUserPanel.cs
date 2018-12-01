using SmartCabs.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartCabs.BAL
{
    public class RegisterUserPanel
    {
        DataAccessLayer DAL = new DataAccessLayer();


        private string userName;
        private string password;
        private int userTypeId;
        private string fullName;
        private string emailId;
        private string mobile;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public int UserTypeId
        {
            get { return userTypeId; }
            set { userTypeId = value; }
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




        public DataTable populateUserType()
        {

            DataTable dt = new DataTable();


            dt = DAL.PopulateDropDown("SELECT * FROM dbo.UserTypeMF");
            return dt;
        }
        public bool CreateUser()
        {

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@UserName",
                    Value=UserName
                },

                new SqlParameter()
                {
                    ParameterName="@Password",
                    Value=Password
                },
                new SqlParameter()
                {
                    ParameterName="@UserTypeId",
                    Value=UserTypeId
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


            return DAL.spExecuteWithReturnValue("spInsertStaff", param);
        }
    }
}