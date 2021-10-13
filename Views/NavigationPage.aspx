<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="NavigationPage.aspx.cs" Inherits="ProjectPSD.Views.NavigationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblName" Text="Name" runat="server" />
    <asp:Label ID="lblWelcome" Text="" runat="server" />

    <br />
    <asp:Button ID="btnLogin" OnClick="btnLogin_Click" Visible="false" Text="Login" runat="server" />
    <asp:Button ID="btnRegister" OnClick="btnRegister_Click" Visible="false" Text="Register" runat="server" />
    <asp:Button ID="btnLogout" OnClick="btnLogout_Click" Visible="false" Text="Logout" runat="server" />
    <br />
    <asp:Button ID="btnHome" OnClick="btnHome_Click" Visible="false" Text="Home" runat="server" />
    <asp:Button ID="btnRedeem" OnClick="btnRedeem_Click" Visible="false" Text="Redeem Token" runat="server" />
    <br />
    <br />
    <asp:Button ID="btnTransact" OnClick="btnTransact_Click" Visible="false" Text="Transactions" runat="server" />
    <asp:Button ID="btnAcc" OnClick="btnAcc_Click" Visible="false" Text="Update Account" runat="server" />
    <br />
    <br />
    <asp:Button ID="btnAddShow" OnClick="btnAddShow_Click" Visible="false" Text="Add Show" runat="server" />
    <asp:Button ID="btnReports" OnClick="btnReports_Click" Visible="false" Text="Reports" runat="server" />
    
</asp:Content>
