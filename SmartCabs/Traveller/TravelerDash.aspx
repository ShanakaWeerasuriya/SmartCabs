<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TravelerDash.aspx.cs" Inherits="SmartCabs.Driver.DriverDash" MasterPageFile="~/SmartCabs.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<asp:Content ID="headID" runat="server" ContentPlaceHolderID="head">
    <style>
        .StarRating {
            width: 50px;
            height: 50px;
            cursor: pointer;
            background-repeat: no-repeat;
            display: block;
            padding:0;
            margin:0;
        }

        .FilledStars {
            background-image: url(~/Images/FullStar.png);
        }

        .WaitingStars {
            background-image: url(~/Images/WaitingStar.png);
        }

        .EmptyStars {
            background-image: url(~/Images/EmptyStar.png);
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Body_PlaceHolder">

    <form id="myform" runat="server">

        <div class="row">

            <div class="col-lg-9 bg-success ">
                <div class="form-group">
                    <div class="col-lg-2">
                        <h2>Current Booking Status</h2>
                        <hr />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Driver Name</asp:Label>
                        <span id="DriverName"></span>
                        <br />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Pickup Location</asp:Label>
                        <span id="TravellerPickupLocation"></span>
                        <br />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Drop off Location</asp:Label>
                        <span id="TravellerDropLocation"></span>
                        <br />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Ratings</asp:Label>

                    </div>
                    <div>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="updatepanel1" runat="server">
                            <ContentTemplate>
                               <asp:Rating ID="rating1" runat="server" StarCssClass="StarRating" FilledStarCssClass="FilledStars"
                                           EmptyStarCssClass="EmptyStars" WaitingStarCssClass="WaitingStars">

                               </asp:Rating>     
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                  
              </div>
            </div>
            </div>



    </form>

</asp:Content>
