<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeRecords.aspx.cs" Inherits="EmployeeRecords" %>

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
        Employee Records:
        <br />
        <br />
        <asp:Button ID="btn_Display" runat="server" Text="Display Employee Records" OnClick="btn_Display_Click" />
    </div>
    </form>
</body>
</html>
