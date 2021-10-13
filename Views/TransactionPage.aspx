<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="ProjectPSD.Views.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gvTransaction" AutoGenerateColumns="False" OnRowEditing="gvTransaction_RowEditing" runat="server">
        <Columns>

            <asp:BoundField DataField="Show.ID" HeaderText="ID" SortExpression="Show.ID" />
            <asp:BoundField DataField="Show.Name" HeaderText="Show Name" SortExpression="Show.Name" />
            <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Action" ShowHeader="True" Text="Transaction Detail Page" />


        </Columns>
    </asp:GridView>
  
    <div>
        <p>Select Transaction !</p>
    </div>
</asp:Content>
