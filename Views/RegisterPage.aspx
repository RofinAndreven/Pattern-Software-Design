<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectPSD.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register</h1>
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
            <asp:Label ID="lblUsername" Text="Username" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />
            <br />
                    <asp:RegularExpressionValidator runat="server"
                     ControlToValidate="txtUsername"
                     ValidationExpression="^(.{6,20}|[^0-9]*|[^a-z]*|[a-zA-Z0-9_\s]*)$"
                     ErrorMessage="Username must be between 6-20 characters, alphanumeric with space or underscore">
                    </asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Label ID="lblPassword" Text="Password" runat="server" />
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" />
            <br />
                    <asp:RegularExpressionValidator runat="server"
                     ControlToValidate="txtPassword"
                     ValidationExpression="^(.{0,6}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$"
                     ErrorMessage="Password must be at least 6 characters, contains number, uppercase, lowercase, and symbol)">
                    </asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Label ID="lblConfirmPassword" Text="Confirm Password" runat="server" />
            <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" />
        </div>
        <div>
             <asp:Label ID="lblRoles" Text="Roles" runat="server" />
             <asp:DropDownList ID = "ddlRoles" runat="server">
                 <asp:ListItem  Value="" Text="--Select Role--" />
                 <asp:ListItem Value="Seller" Text="Seller" />
                 <asp:ListItem Value="Buyer" Text="Buyer" />
             </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lblError" Text="" ForeColor="Red" runat="server" />
                <br />
            <asp:Button ID="btnRegister" Text="Register" runat="server" OnClick="btnRegister_Click" />
            <br />
            <asp:LinkButton ID="linkLogin" Text="Have an account? click here!" runat="server" OnClick="linkLogin_Click"/>
        </div>
</asp:Content>
