using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace SmartCabs.BAL
{
    public class SendEmail
    {


        public  void SendPasswordResetEmail(string ToEmail, string userName, string passWord,string fullName)
        {

            //Calling Mail class constructor 
            MailMessage mailMesseage = new MailMessage("smartcarslive@gmail.com", ToEmail);

            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear" + "  " + fullName + ",<br/><br>");
            sbEmailBody.Append("<h2>Welcome To Smart Cars!!!!!</h2> ");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("Live Account successfully Created.");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("Account User Name : " +userName+ "" );
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("Account Password : " + passWord+ "");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("Click Following link to login");
            sbEmailBody.Append("<br/>");
            sbEmailBody.Append("http://localhost:55794/Registration/Login.aspx");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b> Smart Cars - Your Journey Is Our Job");

            mailMesseage.IsBodyHtml = true;

            mailMesseage.Body = sbEmailBody.ToString();
            mailMesseage.Subject = "Account Creation";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);


            //giving password and username of the sending email id
            smtpClient.Credentials = new NetworkCredential()
            {
                UserName = "smartcarslive@gmail.com",
                Password = "SmartCarsTest"
            };


            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMesseage);



        }


    }
}