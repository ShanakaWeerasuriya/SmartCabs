<%@ Page Title="" Language="C#" MasterPageFile="~/SmartCabs.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SmartCabs.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">
    <form runat="server">
    <div class=".container-fluid ">

        <div class="row">
             <div class="col-1">
            <asp:ImageButton  id="btnTraveller" runat="server" ImageUrl="~/Images/traveller.jpg"  OnClick="btnTraveller_Click" style="background-repeat:no-repeat; width:500px;height:500px;margin-top:100px" />
            </div>
        </div>

        <div class="col-1">
            <asp:ImageButton  id="btnDriver" runat="server" ImageUrl="~/Images/taxi.jpg"  OnClick="btnDriver_Click" style="background-repeat:no-repeat; width:500px;height:500px;margin-top:100px" />
            
        </div>

        </div>
       
        </form>
</asp:Content>
