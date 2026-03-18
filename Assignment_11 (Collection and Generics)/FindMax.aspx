<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindMax.aspx.cs" Inherits="FindMax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Number 1st Number: 
            <br />
            <br />
            <asp:TextBox ID="txt_num1" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Number 2nd Number: 
            <br />
            <br />
            <asp:TextBox ID="txt_num2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Max" runat="server" Text="Find Max" OnClick="btn_Max_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Max" runat="server" Text="Max Output"></asp:Label>
        </div>
    </form>
</body>
</html>
