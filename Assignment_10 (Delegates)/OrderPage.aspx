<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderPage.aspx.cs" Inherits="OrderPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_POrder" runat="server" Text="Place Order" OnClick="btn_POrder_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Order_Output" runat="server" Text="Order Placing Output!!!"></asp:Label>
        </div>
    </form>
</body>
</html>
