using SmartCabs.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartCabs.BAL
{
    public class LoginControl
    {
        private string userName;
        private string password;
        private int userTypeId;

        DataAccessLayer DAL = new DataAccessLayer();
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




        public DataTable populateUserType()
        {
            
           return DAL.PopulateDropDown("SELECT * FROM UserTypeMF");
        }

        public int Login()
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@userName",
                    Value=UserName
                },

                new SqlParameter()
                {
                    ParameterName="@password",
                    Value=Password
                },

                new SqlParameter()
                {
                    ParameterName="@userType",
                    Value=UserTypeId
                },
                 new SqlParameter()
                {
                    ParameterName="@ReturnCode",
                    SqlDbType=SqlDbType.Int,
                    Direction=ParameterDirection.Output
                      
                }
                

            };

          
           return DAL.spLogin("spLogin",param);
        }
    }
}