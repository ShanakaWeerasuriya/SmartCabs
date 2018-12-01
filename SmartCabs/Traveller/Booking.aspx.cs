using SmartCabs.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartCabs.Traveller
{
    public partial class Booking : System.Web.UI.Page
    {
        Bookings BO = new Bookings();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BO.setCitites(this);
                BO.setVeihicleType(this);
            }
        }

        protected void btnPlaceBooking_Click(object sender, EventArgs e)
        {
            BO.PickupAddress = txtPickupAddress.Text;
            BO.PickupDate = txtDate.Text;
            BO.PickupTime = txtTime.Text;
            BO.PickupAddress = txtPickupAddress.Text;
            BO.SelectedDriver = txtDriver.Text;
            BO.City = cmbCity.SelectedItem.Text.ToString();
            BO.Town = txtTown.Text;
            BO.VehicleType =Convert.ToInt16(cmbVehicleType.SelectedValue);
            
            string result = BO.sendSMS();
            

        }

        protected void btnRefreshData_Click(object sender, EventArgs e)
        {

        }

        protected void selectDriver_Click(object sender, EventArgs e)
        {
            

           DriverDetailMPOP.Show();
        }

        protected void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

            BO.loadDrivers(this);
        }
    }
}