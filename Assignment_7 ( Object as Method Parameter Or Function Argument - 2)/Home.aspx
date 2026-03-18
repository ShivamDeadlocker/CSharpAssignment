<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Employee Id: 
            <asp:TextBox ID="txt_EmpID" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Employee Name: 
            <asp:TextBox ID="txt_EmpName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Your Basic Salary: 
            <asp:TextBox ID="txt_EmpSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_NetSalary" runat="server" OnClick="btn_NetSalary_Click" Text="Calculate Your NetSalary" />
            <br />
            <br />
            Your Salary Information:
            <br />
            <br />
            <asp:Label ID="lbl_Salary_Info" runat="server" Text="Your Salary Info"></asp:Label>
        </div>
    </form>
</body>
</html>
