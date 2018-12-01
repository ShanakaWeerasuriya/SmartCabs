using SmartCabs.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartCabs.BAL
{
    public class DriverPanel
    {
        DataAccessLayer DAL = new DataAccessLayer();


        private string driverName;
        private string password;
        private int vehicleTypeId;
        private string fullName;
        private string emailId;
        private string mobile;
        private string vehicleNumber;
        private string vehicleDescription;

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public int VehicleTypeId
        {
            get { return vehicleTypeId; }
            set { vehicleTypeId = value; }
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


        public string VehicleDescription
        {
            get { return vehicleDescription; }
            set { vehicleDescription = value; }
        }


        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }



        public DataTable populateVehicleType()
        {

            DataTable dt = new DataTable();


            dt = DAL.PopulateDropDown("SELECT * FROM dbo.VehicleType");
            return dt;
        }




        public bool CreateDriver()
        {

            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@DriverName",
                    Value=DriverName
                },

                new SqlParameter()
                {
                    ParameterName="@Password",
                    Value=Password
                },
                new SqlParameter()
                {
                    ParameterName="@VehicleTypeID",
                    Value=VehicleTypeId
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

                     new SqlParameter()
                {
                    ParameterName="@VehicleDescription",
                    Value=VehicleDescription
                },
                          new SqlParameter()
                {
                    ParameterName="@VehicleNumber",
                    Value=VehicleNumber
                }
            };


            return DAL.spExecuteWithReturnValue("spInsertDriver", param);
        }

    }
}