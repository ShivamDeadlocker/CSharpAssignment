<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankPortal.aspx.cs" Inherits="BankPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bank Payment Processing Page:
            <br />
            <br />
            Saving Account Section:
            <br />
            <br />
            <asp:Button ID="btn_SADeposit" runat="server" Text="Deposit" OnClick="btn_SADeposit_Click" />
            <br />
            <br />
            <asp:Button ID="btn_SABalance" runat="server" Text="Balance" OnClick="btn_SABalance_Click" />
            <br />
            <br />
            Enter The Amount For Withdraw (SA):
            <br />
            <br />
            <asp:TextBox ID="txt_SAWAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_SAWithDraw" runat="server" Text="Withdraw" OnClick="btn_SAWithDraw_Click" />
            <br />
            <br />
            Current Account Section:
            <br />
            <br />
            <asp:Button ID="btn_CADeposit" runat="server" Text="Deposit" OnClick="btn_CADeposit_Click" />
            <br />
            <br />
            <asp:Button ID="btn_CABalance" runat="server" Text="Balance" OnClick="btn_CABalance_Click" />
            <br />
            <br />
            Enter The Amount For Withdraw (CA):
            <br />
            <br />
            <asp:TextBox ID="txt_CAWAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_CAWithDraw" runat="server" Text="Withdraw" OnClick="btn_CAWithDraw_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Deposit" runat="server" Text="Deposit Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Balance" runat="server" Text="Balance Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_WithDraw" runat="server" Text="WithDraw Informatio"></asp:Label>
        </div>
    </form>
</body>
</html>
