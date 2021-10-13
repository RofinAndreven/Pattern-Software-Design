<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="InsertShow.aspx.cs" Inherits="ProjectPSD.Views.InsertShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add Show</h2>
    <div>
        <asp:Label ID="lblName" Text="Name" runat="server" />
        <asp:TextBox ID="txtName" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblURL" Text="URL" runat="server" />
        <asp:TextBox ID="txturl" Textmode="Url" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblDescription" Text="Description" runat="server" />
        <asp:TextBox ID="txtDescription" runat="server" />
    </div>
    <div>
        <asp:Label ID="LblPrice" Text="Price" runat="server" />
        <asp:TextBox ID="txtPrice" Textmode="Number" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" ForeColor="Red" Text="" runat="server" />
       <br />
        <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" />
        <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" />    
    </div>
    

</asp:Content>
    