<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl_bin" runat="server" Text="My Bin: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_binItems" runat="server" Text="My Bin Items"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Golden Ticket Found At: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_output" runat="server" Text="Golden Ticket Position"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_find" runat="server" Text="Find" OnClick="btn_Find_Click" />
    </div>



    </form>
</body>
</html>
