using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace SmartCabs.BAL
{
    public class SmsApi
    {


        public string SendSMS(string TravelerNumber, string TravelerName, string DriverName,string DriverContactNo , string PickupTime,string pickupDate, string pickupAddress, string VehicleNumber, string referance)
        {


            StringBuilder MessegeBody = new StringBuilder();
            MessegeBody.Append("SMART CABS : BOOKING REF#" + referance + "\n");
            MessegeBody.Append("Customer Name: "+TravelerName+ "\n");
            MessegeBody.Append("Driver Name : BOOKING REF#" + DriverName + "\n");
            MessegeBody.Append("Driver Contact No :" + DriverContactNo + "\n");
            MessegeBody.Append("Vehicle No: " + VehicleNumber+ "\n");
            MessegeBody.Append("Pickup Address: " + pickupAddress + "\n");
            MessegeBody.Append("Pickup Date: " + pickupDate + "\n");
            MessegeBody.Append("Pickup Time: " + PickupTime + "\n");
            MessegeBody.Append("Have A Wonderfull Journey!!!");


            String message = HttpUtility.UrlEncode(MessegeBody.ToString());
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"apikey" , "myLhZLkRJHk-I7eV20guqA0frQ5Xjus9IMvYZFNUQQ"},
                {"numbers" , DriverContactNo},
                {"numbers" , TravelerNumber},
                {"message" , message},
                {"sender" , "Smart Cabs"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }
    }
}

