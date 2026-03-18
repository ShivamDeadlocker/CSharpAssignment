<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GenericReport.aspx.cs" Inherits="GenericReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="btn_Employee" runat="server" Text="Emplopyee Report" OnClick="btn_Employee_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Product" runat="server" Text="Product Report" OnClick="btn_Product_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Order" runat="server" Text="Order Report" OnClick="btn_Order_Click" />
        </div>
    </form>
</body>
</html>
