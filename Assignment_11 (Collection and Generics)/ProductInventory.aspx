<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductInventory.aspx.cs" Inherits="ProductInventory" %>

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
            <asp:Button ID="btn_AddProduct" runat="server" Text="Add Product" OnClick="btn_AddProduct_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Display" runat="server" Text="Display Product" OnClick="btn_DisplayProduct_Click" />
            <br />
            <br />
            Enter Product Id For Searching:
            <br />
            <br />
            <asp:TextBox ID="txt_Id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Find" runat="server" Text="Search Product" OnClick="btn_FindProduct_Click" />
        </div>
    </form>
</body>
</html>
