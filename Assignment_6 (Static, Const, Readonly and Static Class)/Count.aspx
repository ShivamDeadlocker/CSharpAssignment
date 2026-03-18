<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Count.aspx.cs" Inherits="Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_AddEmp" runat="server" Text="Add Employee" OnClick="btn_Add_Emp_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Emp_Count" runat="server" Text="Employee Count Info"></asp:Label>
        </div>
    </form>
</body>
</html>
