<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ShowDetailPage.aspx.cs" Inherits="ProjectPSD.Views.ShowDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Show Detail Page!</h2>
    <asp:Label ID="lblWelcome" Text="" runat="server" />
<%--    <asp:GridView ID="gvShowDetail" runat="server" AutoGenerateColumns="false" OnRowCommand="gvShowDetail_RowCommand">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Show Name" SortExpression="Name" />
            <asp:BoundField DataField="Price" HeaderText="Show Price" SortExpression="Price" />
            <asp:BoundField DataField="User.Name" HeaderText="Seller Name" SortExpression="User.Name" />
            <asp:BoundField DataField="Description" HeaderText="Show Description" SortExpression="Description" />
            <asp:BoundField DataField="Reviews.Rating" HeaderText="Average Rating" SortExpression="Reviews.Rating" />
            <asp:BoundField DataField="Reviews.Description" HeaderText="Reviews" ShowHeader="true" SortExpression="Reviews.Description" />
        </Columns>
    </asp:GridView>--%>
    <div>
        <asp:Label ID="lblShowName" Text="Show Name : " runat="server" />
        <br />
        <asp:Label ID="lblPrice" Text="Show Price : " runat="server" />
        <br />
        <asp:Label ID="lblSellerName" Text="Seller Name : " runat="server" />
        <br />
        <asp:Label ID="lblDescription" Text="Description : " runat="server" />
        <br />
        <asp:Label ID="lblReviewRating" Text="Review Rating : " runat="server" />
        <br />
        <asp:Label ID="lblReviewDesc" Text="Review Description : " runat="server" />
    </div>
    <div>
        <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" Visible="false" Text="Update Show" runat="server" />
        <asp:Button ID="btnOrder" OnClick="btnOrder_Click" Text="Order" Visible="false" runat="server" />
    </div>
</asp:Content>
