<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankingTransactionSystem.aspx.cs" Inherits="BankingTransactionSystem" %>

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
            <asp:Button ID="btn_Display" runat="server" Text="Add Previous Details of Transactions" OnClick="btn_Display_Click" />
            <br />
            <br />
            Enter The Account Number: 
            <br />
            <br />
            <asp:TextBox ID="txt_ANumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter The Customer name: 
            <br />
            <br />
            <asp:TextBox ID="txt_CName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Add" runat="server" Text="Add" OnClick="btn_Add_Click" />
            <br />
            <br />
            <asp:Button ID="btn_DisplayAll" runat="server" Text="Display All" OnClick="btn_DisplayAll_Click" />
            <br />
            <br />
            Enter The Account number for searching: 
            <br />
            <br />
            <asp:TextBox ID="txt_SNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" />
        </div>
    </form>
</body>
</html>
