<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoanPortal.aspx.cs" Inherits="LoanPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Details for Loan:
        <br />
            <br />
            Enter the Loan ID:
        <asp:TextBox ID="txt_LId" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Customer Name:
        <asp:TextBox ID="txt_CName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Loan Amount:
        <asp:TextBox ID="txt_LAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_HomeLoan" runat="server" Text="Home Loan" OnClick="btn_HomeLoan_Click" />
            <br />
            <br />
            <asp:Button ID="btn_CarLoan" runat="server" Text="Car Loan" OnClick="btn_CarLoan_Click" style="height: 26px" />
            <br />
            <br />
            <asp:Button ID="btn_PersonalLoan" runat="server" Text="Personal Loan" OnClick="btn_PersonalLoan_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_HomeLoan" runat="server" Text="Home Loan Output"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_CarLone" runat="server" Text="Car Loan Output"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_PersonalLoan" runat="server" Text="Personal Loan Output"></asp:Label>
        </div>
    </form>
</body>
</html>
