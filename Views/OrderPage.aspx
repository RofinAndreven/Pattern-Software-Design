<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Main.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="ProjectPSD.Views.OrderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h2>Order Page</h2>
    </div>
    <asp:Button ID="btnNavigation" OnClick="btnNavigation_Click" Text="Navigation Page" runat="server" />
    <div>
         <asp:Label ID="lblMovie" Text="" ForeColor="Black" font-size="XX-Large" runat="server" />
    </div>
    <div>
        <asp:GridView ID="gvCarts" runat="server"></asp:GridView>
    </div>
    <asp:Label ID="lblQty" Text="Quantity" runat="server" />
    <asp:TextBox ID="txtQty" runat="server" />
    <br />
    <div>
         <asp:Label ID="lblTime1" Text="00:00 - 00:59"  runat="server" />
        <asp:Button ID="btnOrder1" Text="Order" runat="server" OnClick="btnOrder1_Click" />
        <asp:Label ID="LblError1" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
   <br />
    <div>
        <asp:Label ID="lblTime2" Text="01:00 - 01:59"   runat="server" />
        <asp:Button ID="btnOrder2" Text="Order" runat="server" OnClick="btnOrder2_Click" />
        <asp:Label ID="LblError2" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime3" Text="02:00 - 02:59"  runat="server" />
        <asp:Button ID="btnOrder3" Text="Order" runat="server" OnClick="btnOrder3_Click" />
        <asp:Label ID="LblError3" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    
    <div>
        <asp:Label ID="lblTime4" Text="03:00 - 03:59"  runat="server" />
        <asp:Button ID="btnOrder4" Text="Order" runat="server" OnClick="btnOrder4_Click" />
        <asp:Label ID="LblError4" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime5" Text="04:00 - 04:59"  runat="server" />
        <asp:Button ID="btnOrder5" Text="Order" runat="server" OnClick="btnOrder5_Click" />
        <asp:Label ID="LblError5" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
   
    <div>
        <asp:Label ID="lblTime6" Text="05:00 - 05:59"  runat="server" />
         <asp:Button ID="btnOrder6" Text="Order" runat="server" OnClick="btnOrder6_Click" />
        <asp:Label ID="LblError6" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime7" Text="06:00 - 06:59"  runat="server" />
         <asp:Button ID="btnOrder7" Text="Order" runat="server" OnClick="btnOrder7_Click" />
        <asp:Label ID="LblError7" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime8" Text="07:00 - 07:59"  runat="server" />
         <asp:Button ID="btnOrder8" Text="Order" runat="server" OnClick="btnOrder8_Click" />
        <asp:Label ID="LblError8" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime9" Text="08:00 - 08:59"  runat="server" />
         <asp:Button ID="btnOrder9" Text="Order" runat="server" OnClick="btnOrder9_Click" />
        <asp:Label ID="LblError9" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime10" Text="09:00 - 09:59"  runat="server" />
         <asp:Button ID="btnOrder10" Text="Order" runat="server" OnClick="btnOrder10_Click" />
        <asp:Label ID="LblError10" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="LabelTime11" Text="10:00 - 10:59"  runat="server" />
        <asp:Label ID="LblError11" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
        <asp:Button ID="btnOrder11" OnClick="btnOrder11_Click" Text="Order" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime12" Text="11:00 - 11:59"  runat="server" />
        <asp:Button ID="btnOrder12" OnClick="btnOrder12_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError12" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime13" Text="12:00 - 12:59"  runat="server" />
        <asp:Button ID="btnOrder13" OnClick="btnOrder13_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError13" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime14" Text="13:00 - 13:59"  runat="server" />
        <asp:Button ID="btnOrder14" OnClick="btnOrder14_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError14" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime15" Text="14:00 - 14:59"  runat="server" />
        <asp:Button ID="btnOrder15" OnClick="btnOrder15_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError15" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime16" Text="15:00 - 15:59"  runat="server" />
        <asp:Button ID="btnOrder16" OnClick="btnOrder16_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError16" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime17" Text="16:00 - 16:59"  runat="server"/>
        <asp:Button ID="btnOrder17" OnClick="btnOrder17_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError17" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime18" Text="17:00 - 17:59"  runat="server" />
        <asp:Button ID="btnOrder18" OnClick="btnOrder18_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError18" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

    <div>
        <asp:Label ID="lblTime19" Text="18:00 - 18:59"  runat="server" />
        <asp:Button ID="btnOrder19" OnClick="btnOrder19_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError19" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime20" Text="19:00 - 19:59"  runat="server" />
        <asp:Button ID="btnOrder20" OnClick="btnOrder20_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError20" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime21" Text="20:00 - 20:59"  runat="server" />
        <asp:Button ID="btnOrder21" OnClick="btnOrder21_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError21" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime22" Text="21:00 - 21:59"  runat="server" />
        <asp:Button ID="btnOrder22" OnClick="btnOrder22_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError22" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime23" Text="22:00 - 22:59"  runat="server" />
        <asp:Button ID="btnOrder23" OnClick="btnOrder23_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError23" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label ID="lblTime24" Text="23:00 - 23:59"  runat="server" />
        <asp:Button ID="btnOrder24" OnClick="btnOrder24_Click" Text="Order" runat="server" />
        <asp:Label ID="LblError24" Text="Unavailable" Visible="false" ForeColor="Red" runat="server" />
    </div>
    <br />

</asp:Content>
