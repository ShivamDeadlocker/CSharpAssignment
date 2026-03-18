<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BonusPage.aspx.cs" Inherits="BonusPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Salary: 
            <asp:TextBox ID="txt_Salary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Bonus" runat="server" Text="Get Your Bonus" OnClick="btn_Bonus_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_BonusSalary_Output" runat="server" Text="Bonus Salary Output!!!"></asp:Label>
        </div>
    </form>
</body>
</html>
