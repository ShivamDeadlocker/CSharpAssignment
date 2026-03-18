<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Button ID="btn_CPay" runat="server" Text="Do Payment Using Credit Card" OnClick="btn_CPay_Click" />
                <br />
                <br />
                <asp:Button ID="btn_UPay" runat="server" Text="Do Payment Using UPI" OnClick="btn_UPay_Click" />
                <br />
                <br />
                <asp:Button ID="btn_NPay" runat="server" Text="Do Payment Using Net Banking" OnClick="btn_NPay_Click" />
                <br />
                <br />
                <asp:Label ID="lbl_Pay_Output" runat="server" Text="Payment Result!!!"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
