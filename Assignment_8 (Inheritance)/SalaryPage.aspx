<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalaryPage.aspx.cs" Inherits="SalaryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter Details for Employee:
        <br />
        <br />
         Enter the Emp ID:
        <asp:TextBox ID="txt_EmpId" runat="server"></asp:TextBox>
        <br />
        <br />
         Enter the Emp Name:
        <asp:TextBox ID="txt_EmpName" runat="server"></asp:TextBox>
        <br />
        <br />
         Enter the Emp Basic Salary:
        <asp:TextBox ID="txt_BasicSal" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_Contract" runat="server" Text="Contract Based Employee" OnClick="btn_Contract_Click" />
        <br />
        <br />
        <asp:Button ID="btn_Permenant" runat="server" Text="Permenant Employee" OnClick="btn_Permenant_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_Contract" runat="server" Text="Contract Based Employee Salary"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_Permenant" runat="server" Text="Permenant Employee Salary"></asp:Label>
    </div>
    </form>
</body>
</html>
