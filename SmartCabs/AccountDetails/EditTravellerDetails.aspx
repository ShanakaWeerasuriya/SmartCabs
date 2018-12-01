<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditTravellerDetails.aspx.cs" Inherits="SmartCabs.AccountDetails.EditTravellerDetails" MasterPageFile="~/Registration/Register.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavigatedPath_PlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">

    <form id="form1" runat="server">
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-horizontal form-control-sm">
            <h4>Edit Traveller Details</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />

             <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtTravellerName" CssClass="col-sm-12 control-label">User Name</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtTravellerName" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTravellerName"
                        CssClass="text-danger" ErrorMessage="The User Name is required." />
                </div>
            </div>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtFullName" CssClass="col-sm-12 control-label">Full Name</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtFullName" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFullName"
                        CssClass="text-danger" ErrorMessage="The Full Name is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-sm-12 control-label">Email</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control form-control-sm" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                        CssClass="text-danger" ErrorMessage="The email field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtMobile" CssClass="col-sm-12 control-label">Mobile Number</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtMobile" CssClass="form-control form-control-sm" TextMode="Phone" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtMobile"
                        CssClass="text-danger" ErrorMessage="Mobile Number is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-sm-12 control-label">Password</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                        CssClass="text-danger" ErrorMessage="The password field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="txtConfirmPassword" CssClass="col-sm-12  control-label">Confirm password</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password" CssClass="form-control form-control-sm" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                    <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                </div>
            </div>

            <div class="form-group">
                <table>
                    <tr>
                        <td>
                            <div class="col-md-offset-2 col-sm-12">
                                <asp:Button ID="btnEdit" runat="server" Text="Edit Details" CssClass="btn btn-primary" OnClick="btnEdit_Click" CausesValidation="False"/>
                            </div>
                        </td>
                        <td class="auto-style1">
                            <div class="col-md-offset-2 col-sm-12">
                                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</asp:Content>