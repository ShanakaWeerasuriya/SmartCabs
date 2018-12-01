<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" MasterPageFile="~/SmartCabs.Master" Inherits="SmartCabs.Traveller.Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">

    <form id="form1" runat="server">
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-horizontal form-control-sm">
            <h4>Place Your Booking</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtPickupAddress" CssClass="col-sm-12 control-label">Pickup Address </asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtPickupAddress" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPickupAddress" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="The Pickup Address is required." />
                </div>
            </div>


            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtTown" CssClass="col-sm-12 control-label">Town</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtTown" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTown" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="The Town Name is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="cmbCity" CssClass="col-sm-12 control-label">City</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList runat="server" ID="cmbCity" CssClass="form-control form-control-sm"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbCity" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="Select the City." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtTravellerMobile" CssClass="col-sm-12 control-label">Mobile Number</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtTravellerMobile" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTravellerMobile" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="The Mobile Number is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtDate" CssClass="col-sm-12 control-label">Pickup Date & Time</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtDate" CssClass="form-control form-control-sm" TextMode="Date" />
                    <p></p>
                    <asp:TextBox runat="server" ID="txtTime" CssClass="form-control form-control-sm" TextMode="Time" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDate" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="Date is required." />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTime" ValidationGroup="BookingValidate"
                        CssClass="text-danger" ErrorMessage="Time is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="cmbVehicleType" CssClass="col-sm-12 control-label">Vehicle Type</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList runat="server" ID="cmbVehicleType" CssClass="form-control form-control-sm" OnSelectedIndexChanged="cmbVehicleType_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbVehicleType"
                        CssClass="text-danger" ErrorMessage="Select the vehicle type." ValidationGroup="BookingValidate" />
                </div>
            </div>

            <div class="form-group">
                <table>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="txtPickupAddress" CssClass="col-sm-12 control-label">Selected Driver </asp:Label>
                            <div class="col-md-10">
                                <asp:TextBox runat="server" ID="txtDriver" CssClass="form-control form-control-sm" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPickupAddress" ValidationGroup="BookingValidate"
                                    CssClass="text-danger" ErrorMessage="The Pickup Address is required." />
                            </div>
                        </td>
                        <td>
                            <div class="col-md-offset col-sm-12">
                                <asp:Button ID="selectDriver" runat="server" Text="SELECT DRIVER" CssClass="btn btn-danger form-control form-control-sm" OnClick="selectDriver_Click"/>
                            </div>
                        </td>
                    </tr>
                </table>

            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-sm-12">
                    <asp:Button ID="btnPlaceBooking" runat="server" Text="Place Booking" CssClass="btn btn-primary" OnClick="btnPlaceBooking_Click" />
                </div>
            </div>
        </div>

      
         
        <%-- Grid VIew Pop up --%>


        <asp:ScriptManager ID="DriverScript" runat="server">
        </asp:ScriptManager>

        <asp:HiddenField ID="EmpID" runat="server" />

        <ajaxToolkit:ModalPopupExtender ID="DriverDetailMPOP" runat="server" PopupControlID="DriverMPOP" TargetControlID="EmpID" PopupDragHandleControlID="head">
        </ajaxToolkit:ModalPopupExtender>

        <asp:UpdatePanel ID="DriverMPOP" runat="server">
            <ContentTemplate>
                <div id="head" class="modal-header" style="height:600px;width:600px;border:5px solid blue ">
                <div id="body">
                    <asp:GridView ID="DriverDetailGrid" runat="server">

                    </asp:GridView>

                </div>
                <div class="modal-footer"> 
                        <asp:Button ID="btnRefreshData" runat="server" Text="Refresh" CssClass="btn btn-primary" OnClick="btnRefreshData_Click" />
                
                </div>
                </div>
            </ContentTemplate>

        </asp:UpdatePanel>


    </form>


</asp:Content>
