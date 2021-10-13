<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="ProjectPSD.Views.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Transaction Detail</h2>
    </div>
    <div>
        <asp:Label ID="lblName" Text="Show Name : " runat="server" />
    </div>
    <div>
        <asp:Label ID="lblSAR" Text="Show Average Rating : " runat="server" />
    </div>
    <div>
        <asp:Label ID="lblDesc" Text="Show Description : " runat="server" />
    </div>
    <div>
        <asp:Label ID="lblToken" Text="Token : " runat="server" />
    </div>
    <div>
        <asp:Button ID="btnCancel" OnClick="btnCancel_Click" Text="Cancel" runat="server" />
    </div>
    <asp:Label ID="lblError" Text="" runat="server" />
</asp:Content>
