<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentPortal.aspx.cs" Inherits="PaymentPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Transaction details:
        <br />
            <br />
            Enter the Transaction Id:
        <asp:TextBox ID="txt_trid" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Amount:
        <asp:TextBox ID="txt_tamount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_CreditCardPayment" runat="server" Text="Use Credit Card Payment" OnClick="btn_CreditCardPayment_Click" />
            <br />
            <br />
            <asp:Button ID="btn_UPIPayment" runat="server" Text="Use UPI Payment" OnClick="btn_UPIPayment_Click" />
            <br />
            <br />
            <asp:Button ID="btn_NetBanking" runat="server" Text="Use Net Banking" OnClick="btn_NetBanking_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_CreditCardPayment" runat="server" Text="Credit Card Payment"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_UPIPayment" runat="server" Text="UPI Payment"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_NetBankingPayment" runat="server" Text="Net Banking Payment"></asp:Label>
        </div>
    </form>
</body>
</html>
