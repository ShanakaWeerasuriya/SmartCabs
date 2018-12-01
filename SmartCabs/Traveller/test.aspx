<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="SmartCabs.Traveller.test" MasterPageFile="~/Registration/Register.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .StarRating {
            width: 50px;
            height: 50px;
            cursor: pointer;
            background-repeat: no-repeat;
            display: block;
        }

        .FilledStars {
            background-image: url("~/Images/FullStar.png");
        }

        .WaitingStars {
            background-image: url("~/Images/WaitingStar.png");
        }

        .EmptyStars {
            background-image: url("~/Images/EmptyStar.png");
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavigatedPath_PlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">

    <form id="form1" runat="server">
       
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

    </form>
</asp:Content>