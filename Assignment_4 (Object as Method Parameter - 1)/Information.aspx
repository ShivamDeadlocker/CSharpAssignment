<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            Student Information:
            Enter Name: &nbsp<asp:TextBox ID="txt_Sname" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Roll Number: &nbsp<asp:TextBox ID="txt_Sroll" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Grade: &nbsp<asp:TextBox ID="txt_Sgrade" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Student" runat="server" Text="Get Student informations" OnClick="btn_Student_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_StudentInfo" runat="server" Text="Studnet Info"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_Redirect" runat="server" Text="Go to Home Page" OnClick="btn_Home_Click" />
    </div>
    </form>
</body>
</html>
