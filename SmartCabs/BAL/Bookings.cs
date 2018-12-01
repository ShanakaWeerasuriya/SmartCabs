using SmartCabs.DAL;
using SmartCabs.Traveller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmartCabs.BAL
{
    public class Bookings
    {

        private string pickupAddress;
        private string town;
        private string city;
        private string pickupDate;
        private string pickupTime;
        private int vehicleType;
        private string selectedDriver;

        public string PickupAddress
        {
            get { return pickupAddress; }
            set { pickupAddress = value; }
        }

        public string Town
        {
            get { return town; }
            set { town = value; }
        }


        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string PickupDate
        {
            get { return pickupDate; }
            set { pickupDate = value; }
        }

        public string PickupTime
        {
            get { return pickupTime; }
            set { pickupTime = value; }
        }

        public int VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public string SelectedDriver
        {
            get { return selectedDriver; }
            set { selectedDriver = value; }
        }


        DataAccessLayer DAL = new DataAccessLayer();
        SmsApi SMS = new SmsApi();
        public string GenerateBookingReferance()
        {
           int Currentreferance=DAL.ReturnCurrentReferance();
            Currentreferance++;

            string NewRefferance = Currentreferance.ToString();
            return NewRefferance;
        }

        public string sendSMS()
        {
            string DriverMobile = "";
            string VehicleNum= "";

            getDriverDetails(out VehicleNum, out DriverMobile);

           return SMS.SendSMS(getTravelerDetails(), "shanaka", SelectedDriver, DriverMobile, PickupTime, PickupDate, PickupAddress, VehicleNum, GenerateBookingReferance());
        }

        public void getDriverDetails(out string vehicleNum,out string mobileNUm) {

            string VehicleNumber = "", MobileNumber = "";
            DAL.DriverDetails(SelectedDriver,out VehicleNumber,out MobileNumber);
            vehicleNum = VehicleNumber;
            mobileNUm = MobileNumber;
            
        }

        public string getTravelerDetails()
        {
            return DAL.TravelerDetails("shanaka");
        }

        public void setCitites(Booking book)
        {
            
            book.cmbCity.Items.Add("Colombo");
            book.cmbCity.Items.Add("Gamapaha");
        }

        public void setVeihicleType(Booking book)
        {
         book.cmbVehicleType.Items.Add("Car");
         book.cmbVehicleType.Items.Add("Van");
         book.cmbVehicleType.Items.Add("Three Wheels");
        }

        public void loadDrivers(Booking book) {


            List<SqlParameter> param = new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName = "@City",
                    Value=City
                },

                new SqlParameter()
                {
                    ParameterName = "@VehicleType",
                    Value=VehicleType
                }
            };

            book.DriverDetailGrid.DataSource = DAL.spExecuteWithReturnDataTable("spLoadDrivers",param);
        }

    }
}