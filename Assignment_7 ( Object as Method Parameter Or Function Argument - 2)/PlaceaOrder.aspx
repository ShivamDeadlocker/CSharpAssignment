<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlaceaOrder.aspx.cs" Inherits="PlaceaOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_AssignDiscount" runat="server" OnClick="btn_AssignDiscount_Click" Text="Get Your Discount" />
        <br />
        <br />
        <asp:Label ID="lbl_Product" runat="server" Text="Product Information"></asp:Label>
    </div>
    </form>
</body>
</html>
