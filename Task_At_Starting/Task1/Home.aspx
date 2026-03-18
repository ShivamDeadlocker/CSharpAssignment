<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Amount:&nbsp; 
        <asp:TextBox ID="txt_TotalAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Order Number: <asp:TextBox ID="txt_OrderNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Order" runat="server" Text="Place Order" OnClick="btn_Order_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Output" runat="server" Text="Place Order Details"></asp:Label>
        </div>
    </form>
</body>
</html>
