<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeesBySalary.aspx.cs" Inherits="EmployeesBySalary" %>

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
            Scenario 1: Filter Employees by Salary
            <br />
            <br />
            <asp:Button ID="btn_GetMax" runat="server" Text="Get Max Salary" OnClick="btn_GetMax_Click" />
            <br />
            <br />
            Scenario 2: Get Employees From Specific Department
            <br />
            <br />
            <asp:TextBox ID="txt_Dept" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Find" runat="server" Text="Find By Dept" OnClick="btn_Find_Click" />
        </div>
    </form>
</body>
</html>
