<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ECommerce.aspx.cs" Inherits="ECommerce" %>

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
            Enter Customer Name: 
            <br />
            <br />
            <asp:TextBox ID="txt_CName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Amount: 
            <br />
            <br />
            <asp:TextBox ID="txt_Amount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Cart" runat="server" Text="Add Order" OnClick="btn_Cart_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Display" runat="server" Text="Display Order" OnClick="btn_Display_Click" />
            <br />
            <br />
            Enter Product Id Which You wanted to remove: 
            <br />
            <br />
            <asp:TextBox ID="txt_RID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Remove" runat="server" Text="Remove Order" OnClick="btn_Remove_Click" />
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
