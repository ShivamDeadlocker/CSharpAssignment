<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingCharges.aspx.cs" Inherits="ShippingCharges" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter Details of Product:
        <br />
        <br />
         Enter the Product ID:
        <asp:TextBox ID="txt_ProId" runat="server"></asp:TextBox>
        <br />
        <br />
         Enter the Customer Name:
        <asp:TextBox ID="txt_CustName" runat="server"></asp:TextBox>
        <br />
        <br />
         Enter the Amount :
        <asp:TextBox ID="txt_Amount" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_Online" runat="server" Text="Online Product" OnClick="btn_Online_Click" />
        <br />
        <br />
        <asp:Button ID="btn_Store" runat="server" Text="Store Product" OnClick="btn_Store_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_Online" runat="server" Text="Online Product Shipping Charges"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Store" runat="server" Text="Store Product Shipping Charges"></asp:Label>
    </div>
    </form>
</body>
</html>
