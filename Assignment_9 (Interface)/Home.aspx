<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Your Payment Methods:
            <br />
            <br />
            <asp:Button ID="btn_Credit_Card" runat="server" Text="Credit Card" OnClick="btn_Credit_Card_Click" />
            <br />
            <br />
            <asp:Button ID="btn_UPI" runat="server" Text="UPI" OnClick="btn_UPI_Click" />
            <br />
            <br />
            <asp:Button ID="btn_NetBanking" runat="server" Text="Net Banking" OnClick="btn_NetBanking_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Amount" runat="server" Text="Payment Amount"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lbl_Validate" runat="server" Text="Validate Payment Amount"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Process" runat="server" Text="Process Payment Amount"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Receipt" runat="server" Text="Generate Receipt For Payment Amount"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
