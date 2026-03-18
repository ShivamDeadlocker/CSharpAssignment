<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HelperPage.aspx.cs" Inherits="HelperPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn_Validate" runat="server" Text="Validate User" OnClick="btn_Validate_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_Validate_Output" runat="server" Text="Validation Check Message"></asp:Label>
    </div>
    </form>
</body>
</html>
