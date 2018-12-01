<%@ Page Title="" Language="C#" MasterPageFile="~/Registration/Register.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SmartCabs.Registration.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">

    <form id="form1" runat="server">
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-horizontal form-control-sm">
            <h4>User Login</h4>
            <hr />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />
        </div>
        <br />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtUserName" CssClass="col-sm-12 control-label">User Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control form-control-sm" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName"
                    CssClass="text-danger" ErrorMessage="The User Name is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPassword" CssClass="col-sm-12 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control form-control-sm" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>

             <div class="form-group">
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="cmbUserType" CssClass="col-sm-12 control-label">User Type</asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList  runat="server" ID="cmbUserType" CssClass="form-control form-control-sm"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="cmbUserType"
                        CssClass="text-danger" ErrorMessage="Select the user type." />
                </div>
                </div>
        </div>

            <div class="form-horizontal form-control-sm  form-check">
                <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
                <a href="#" runat="server" style="margin-left: 155px">Forgot Password</a>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-sm-12">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
