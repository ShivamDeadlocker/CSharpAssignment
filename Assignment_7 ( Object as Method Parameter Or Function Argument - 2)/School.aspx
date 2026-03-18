<%@ Page Language="C#" AutoEventWireup="true" CodeFile="School.aspx.cs" Inherits="School" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Button ID="btn_AssignGrade" runat="server" OnClick="btn_AssignGrade_Click" Text="Get Your Grade" />
        <br />
        <br />
        <asp:Label ID="lbl_StudentInfo" runat="server" Text="Student Information"></asp:Label>
    </div>
    </form>
</body>
</html>
