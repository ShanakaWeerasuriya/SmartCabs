<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TravellerDetails.aspx.cs" Inherits="SmartCabs.AccountDetails.TravellerDetails" MasterPageFile="~/Registration/Register.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavigatedPath_PlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body_PlaceHolder" runat="server">
    <form id="Form1" runat="server">
       <div>
           <asp:GridView ID="gvEditorDelete" runat="server" OnRowEditing="gvEditorDelete_RowEditing"
            BackColor="#cccccc" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDataBound="gvEditorDelete_RowDataBound" OnRowCancelingEdit="gvEditorDelete_RowCancelingEdit" OnRowUpdating="gvEditorDelete_RowUpdating"
            AutoGenerateColumns="False" DataKeyNames="CustomerID">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="true" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#ff5050" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#006699" Font-Bold="true" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor ="#00547E" />

            <Columns>
                <asp:TemplateField HeaderText="Traveller Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("CustomerName") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTravellerName" Text='<%# Eval("CustomerName") %>' runat="server" />
                    </EditItemTemplate>
                    <%--<FooterTemplate>
                        <asp:TextBox ID="txtTravellerNameFooter" Text="" runat="server" />
                    </FooterTemplate>--%>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Full Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("FullName") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFullName" Text='<%# Eval("FullName") %>' runat="server" />
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Mobile") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMobile" Text='<%# Eval("Mobile") %>' runat="server" />
                    </EditItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email Address">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("EmailID") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEmailID" Text='<%# Eval("EmailID") %>' runat="server" />
                    </EditItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UserType">
                    <ItemTemplate>
                        <asp:DropDownList ID="cmbUserType" runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                         <asp:DropDownList ID="cmbUserType" runat="server" />
                    </EditItemTemplate>
                   
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit"
                            Width="20px" Height="20px" /> 
                        <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete"
                            Width="20px" Height="20px" /> 
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update"
                            Width="20px" Height="20px" /> 
                        <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel"
                            Width="20px" Height="20px" />
                    </EditItemTemplate>

                </asp:TemplateField>
            </Columns>

           </asp:GridView>
           <br />
           <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
           <br />
           <asp:Label ID="lblError" Text="" runat="server" ForeColor="Red" />

       </div>

    </form>
</asp:Content>
