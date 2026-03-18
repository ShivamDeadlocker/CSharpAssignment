<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TransferMoney.aspx.cs" Inherits="TransferMoney" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Amount to be transfer: 
        <asp:TextBox ID="txt_money" runat="server"></asp:TextBox>
            <br />
            <br />
            Before Transaction: 
        <br />
            <br />
            Sender Information: 
        <asp:Label ID="lbl_Sender_Info" runat="server" Text="Sender Information"></asp:Label>
            <br />
            <br />
            Receiver Information:
        <asp:Label ID="lbl_Receiver_Info" runat="server" Text="Receiver Information"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_Transfer" runat="server" Text="Transfer" OnClick="btn_Transfer_Click" />
            <br />
            <br />
            After Transaction
            <br />
            <br />
            Sender Information: 
        <asp:Label ID="lbl_Sender_Info_AT" runat="server" Text="Sender Information"></asp:Label>
            <br />
            <br />
            Receiver Information:
        <asp:Label ID="lbl_Receiver_Info_AT" runat="server" Text="Receiver Information"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
