<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCartSystem.aspx.cs" Inherits="ShoppingCartSystem" %>

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
            Enter Product Id: 
            <br />
            <br />
            <asp:TextBox ID="txt_PID" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Product Name: 
            <br />
            <br />
            <asp:TextBox ID="txt_PName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Cart" runat="server" Text="Shopping Cart System" OnClick="btn_Cart_Click" />
            <br />
            <br />
            Enter Product Id Which You wanted to remove: 
            <br />
            <br />
            <asp:TextBox ID="txt_RID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Remove" runat="server" Text="Remove Shopping Cart Items" OnClick="btn_Remove_Click" />
            <br />
            <br />
            Enter Product Id Which You wanted to search: 
            <br />
            <br />
            <asp:TextBox ID="txt_SID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Search" runat="server" Text="Search Shopping Cart Items" OnClick="btn_Search_Click" />
        </div>
    </form>
</body>
</html>
