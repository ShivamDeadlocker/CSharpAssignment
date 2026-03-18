<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentMarks.aspx.cs" Inherits="StudentMarks" %>

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
            Enter Student Marks: 
            <br />
            <br />
            <asp:TextBox ID="txt_Marks" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Student Name: 
            <br />
            <br />
            <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
            <br />
            <br />
            Students Marks Using List Collection: 
            <br />
            <br />
            <asp:Button ID="btn_StudentMarks" runat="server" Text="Display Student Marks" OnClick="btn_StudentMarks_Click" />
        </div>
    </form>
</body>
</html>
