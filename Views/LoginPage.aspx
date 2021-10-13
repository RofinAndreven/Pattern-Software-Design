<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectPSD.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Login</h3>
    <div>
        <asp:Label ID="lblEmail" Text="Email" runat="server" />
        <asp:TextBox ID="txtEmail" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblPassword" Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
    </div>
    <div>
        <asp:CheckBox ID="cbRemember" Text="Remember Me" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" Text="" runat="server" />
        <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
        <asp:Button ID="btnRegister" OnClick="btnRegister_Click" Text="Register" runat="server" />
    </div>
</asp:Content>
