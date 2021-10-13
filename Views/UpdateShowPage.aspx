<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="UpdateShowPage.aspx.cs" Inherits="ProjectPSD.Views.UpdateShowPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="gvShow" runat="server"></asp:GridView>
    </div>
    <div>
        <asp:Label ID="lblID" Text="ID" runat="server" />
        <asp:TextBox ID="txtID" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblName" Text="Name" runat="server" />
        <asp:TextBox ID="txtName" runat="server" />
         <br />
                 <asp:RequiredFieldValidator ID="validateName" 
                    runat="server" ControlToValidate ="txtName"
                    ErrorMessage="Name must be filled" 
                    InitialValue="Name must be filled">
                  </asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="lblURL" Text="URL" runat="server" />
        <asp:TextBox ID="txturl" Textmode="Url" runat="server" />
        <br />
                   <asp:RegularExpressionValidator runat="server"
                     ControlToValidate="txtUrl"
                     ValidationExpression="^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$"
                     ErrorMessage="Must be a valid URL">
                    </asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Label ID="lblDescription" Text="Description" runat="server" />
        <asp:TextBox ID="txtDescription" runat="server" />
        <br />
                  <asp:RequiredFieldValidator ID="validateDesc" 
                    runat="server" ControlToValidate ="txtDescription"
                    ErrorMessage="Description must be filled" 
                    InitialValue="Description must be filled">
                  </asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Label ID="LblPrice" Text="Price" runat="server" />
        <asp:TextBox ID="txtPrice" Textmode="Number" runat="server"  />
        <br />
                    <asp:RegularExpressionValidator runat="server"
                     ControlToValidate="txtPrice"
                     ValidationExpression="^[0-9]*$"
                     ValidationGroup="NumericValidate"
                     MinimumValue="1000"
                     ErrorMessage="Price must be numeric and at least 1000">
                    </asp:RegularExpressionValidator>
    </div>
     <div>
        <asp:Label ID="lblError" ForeColor="Red" Text="" runat="server" />
       <br />
        <asp:Button ID="btnUpdate" OnClick="btnUpdate_Click" Text="Update" runat="server" />
        <asp:Button ID="btnCancel" OnClick="btnCancel_Click" Text="Cancel" runat="server" />
    </div>
</asp:Content>
