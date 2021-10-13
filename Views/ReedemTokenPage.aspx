<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ReedemTokenPage.aspx.cs" Inherits="ProjectPSD.Views.ReedemTokenPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Reedem Token Page</h2>
    <div>
        <asp:Label ID="lblToken" Text="Input Valid Token" runat="server" />
        <asp:TextBox ID="txtToken" runat="server" />
        <br />
        <asp:Button ID="btnReedem" OnClick="btnReedem_Click" Text="Reedem" runat="server" />
        <asp:Button ID="btnNavigation" OnClick="btnNavigation_Click" Text="Navigation Page" runat="server" />
        <div>
            <asp:Label ID="lblError" Text="" runat="server" />
        </div>
    </div>
</asp:Content>
