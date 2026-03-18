<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Taxpay.aspx.cs" Inherits="Taxpay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Money You Have:
            <asp:TextBox ID="txt_Money" runat="server" Placeholder="Enter Money You Have"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Tax" runat="server" Text="Get You Tax " OnClick="btn_Tax_Info_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Tax_Info" runat="server" Text="Your Tax Info"></asp:Label>
        </div>
    </form>
</body>
</html>
