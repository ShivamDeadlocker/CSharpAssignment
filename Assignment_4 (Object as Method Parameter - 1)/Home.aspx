<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name: &nbsp<asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Position: &nbsp<asp:TextBox ID="txt_Position" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Salary: &nbsp<asp:TextBox ID="txt_Salary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Salary" runat="server" Text="Get salary informations" OnClick="btn_CurrentSal_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_SalaryInfo" runat="server" Text="Current Salary Info"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_UpdateSalary" runat="server" Text="Update Salary" OnClick="btn_UpdateSal_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_UpdatedSalary" runat="server" Text="Updated Salary Info"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_Redirect" runat="server" Text="Go to Student Page" OnClick="btn_Student_Click" />
        </div>
    </form>
</body>
</html>
