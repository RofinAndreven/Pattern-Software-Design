<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="ReviewPage.aspx.cs" Inherits="ProjectPSD.Views.ReviewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Review Page</h2>
    </div>
     <asp:Label ID="lblMovie" Text="" ForeColor="Black" font-size="XX-Large" runat="server" />
    <br />
    <asp:Label Text="Seller Name: " ForeColor="Black" Font-Size="Medium" runat="server" />
    <asp:Label ID="lblSeller" Text="" ForeColor="Black" Font-Size="Medium" runat="server" />
    <br />
    <div>
        <asp:Label Text="Description: " ForeColor="Black" Font-size="Medium" runat="server"/>  
        <asp:Label ID="lblDescription" Text="" ForeColor="Black" Font-Size="Medium" runat="server" />

    </div>
    <div>
         <asp:Label Text="Rating: " ForeColor="Black" Font-size="Medium" runat="server"/> 
        <asp:TextBox ID="txtRating" runat="server" textmode="Number"/>
    </div> 
     <div>
         <asp:Label Text="Description: " ForeColor="Black" Font-size="Medium" runat="server"/> 
         <br />
        <asp:TextBox ID="txtDescription" TextMode="MultiLine" Rows="10" runat="server" />
    </div> 
    <br />

    <div>
        <asp:Button ID="btnRate" Text="Rate" runat="server" Visible="false" OnClick="btnRate_Click" />
            <asp:Button ID="btnUpdate" Text="Update" runat="server" Visible="false" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnRemove" Text="Remove" runat="server" Visible="false" OnClick="btnRemove_Click" />
    </div>
    <asp:Button ID="btnNavigation" OnClick="btnNavigation_Click" Text="Navigation Page" runat="server" />
    <br />
    <asp:Label ID="lblError" ForeColor="Red" Text="" runat="server" />




</asp:Content>
