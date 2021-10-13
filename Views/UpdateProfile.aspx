<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="ProjectPSD.Views.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Update Profile</h2>
    <div>
        <asp:Label ID="lblName" Text="Name" runat="server" />
        <asp:TextBox ID="txtName" runat="server" />
         <br />
                    <asp:RegularExpressionValidator runat="server"
                     ControlToValidate="txtName"
                     ValidationExpression="^(.{1,30}|[a-zA-Z\s]*)$"
                     ErrorMessage="Name must be between 1-30 characters, alphabet with space">
                    </asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Label ID="lblOldPassword" Text="Old Password" runat="server" />
        <asp:TextBox ID="txtOldPassword" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblNewPassword" Text="New Password" runat="server" />
        <asp:TextBox ID="txtNewPassword" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblConfirmNew" Text="Confirm New Password" runat="server" />
        <asp:TextBox ID="txtConfirmNew" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
        <br />
        <asp:Button ID="btnUpdate" Text="Update" runat="server" onclick="btnUpdate_Click" />
        <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancel_Click" />
    </div>

</asp:Content>
