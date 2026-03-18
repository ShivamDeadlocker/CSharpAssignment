<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

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
            Enter Product Name:
            <br />
            <br />
            <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Add" runat="server" Text="Add" OnClick="btn_Add_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Display" runat="server" Text="Display" OnClick="btn_Display_Click" />
            <br />
            <br />
            Enter Product Name You Wanted Remove:
            <br />
            <br />
            <asp:TextBox ID="txt_RName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Remove" runat="server" Text="Remove" OnClick="btn_Remove_Click" />

        </div>
    </form>
</body>
</html>
