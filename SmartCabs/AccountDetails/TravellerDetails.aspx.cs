using SmartCabs.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartCabs.AccountDetails
{
    public partial class TravellerDetails : System.Web.UI.Page
    {
        TravellerPanel TP = new TravellerPanel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEditorDelete.DataSource = TP.populateTravellersDataGrid();
                gvEditorDelete.DataBind();
            }
           

        }

        protected void gvEditorDelete_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType.Equals(DataControlRowType.DataRow))
            {
                DropDownList drop1 = e.Row.FindControl("cmbUserType") as DropDownList;

                if (drop1 != null)
                {
                    //for (int i = 1; i < 5; i++)
                    //{
                    //    drop1.Items.Add(i.ToString());
                    //}

                   drop1.DataSource = TP.populateUserTypeID();
                   drop1.DataTextField = "UserTypeId";
                   drop1.DataBind();
                    

                }
            }
        }

        protected void gvEditorDelete_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEditorDelete.EditIndex = e.NewEditIndex;
            gvEditorDelete.DataSource = TP.populateTravellersDataGrid();
          
        }

        protected void gvEditorDelete_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEditorDelete.EditIndex = -1;
            gvEditorDelete.DataSource = TP.populateTravellersDataGrid();
        }

        protected void gvEditorDelete_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            gvEditorDelete.EditIndex = -1;
            if (TP.UpdateTraveller(this,e))
            {
                lblSuccessMessage.Text = "Record Updated Successfull";
            }
            else
            {

                lblError.Text = "Record Updated Unsuccessfull,Please Try Again";
            }


        }
    }
}