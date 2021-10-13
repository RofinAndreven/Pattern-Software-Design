<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectPSD.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Welcome to the Home page!</h2>
    <asp:TextBox ID="txtSearch" runat="server" />
    <asp:Button ID="btnSearch" OnClick="btnSearch_Click" Text="Search" runat="server" />
    <br />
    <%--<asp:GridView ID="gvShowDetailBySearch" AutoGenerateColumns="False" OnRowEditing="gvShowDetailBySearch_RowEditing" runat="server">
        <Columns>

            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="User.Name" HeaderText="Seller Name" SortExpression="User.Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Action" ShowHeader="True" Text="Show Detail" />
        </Columns>
    </asp:GridView>--%>
    <asp:Label ID="lblError" Text="" runat="server" />
    <asp:GridView ID="gvShowDetail" AutoGenerateColumns="False" OnRowEditing="gvShowDetail_RowEditing" runat="server">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />

            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="User.Name" HeaderText="Seller Name" SortExpression="User.Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Action" ShowHeader="True" Text="Show Detail" />

        </Columns>
    </asp:GridView>
    <p>Please chose the shows!</p>
    <div>
        <asp:Button ID="btnCancel" OnClick="btnCancel_Click" Text="Cancel" runat="server" />
    </div>
</asp:Content>
