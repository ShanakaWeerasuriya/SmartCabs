<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriverDash.aspx.cs" Inherits="SmartCabs.Driver.DriverDash" MasterPageFile="~/SmartCabs.Master" %>


<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Body_PlaceHolder">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../js/jquery-3.3.1.min.js"></script>
    <form id="form1" runat="server">

        <div class="row">
            <div class="col-lg-9 bg-success ">
                <div class="form-group">
                    <div class="col-lg-2">
                        <h2>Current Hire Status</h2>
                        <hr />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Traveller Name</asp:Label>
                        <span id="TravellerName"></span>
                        <br />
                        <asp:Label runat="server" CssClass="col-m-12 control-label">Drop off Location</asp:Label>
                        <span id="TravellerDropLocation"></span>
                    </div>

                </div>
            </div>


            <div class="col-lg-9 ">
                <div class="form-group">
                    <div class="col-lg-2">
                        <asp:Label runat="server" AssociatedControlID="cmbTown" CssClass="col-sm-12 control-label">Town</asp:Label>

                        <asp:DropDownList runat="server" ID="cmbTown" CssClass="form-control form-control-sm"></asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbTown"
                            CssClass="text-danger" ErrorMessage="Select the Current City." />

                        <div class="form-group">
                            <div class="col-md-offset-2 col-sm-12">
                                <asp:Button ID="btnON" runat="server" Text="ON" CssClass="btn btn-success"  />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-offset-2 col-sm-12">
                                <asp:Button ID="btnOff" runat="server" Text="OFF" CssClass="btn btn-danger"  />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>


    </form>


</asp:Content>
