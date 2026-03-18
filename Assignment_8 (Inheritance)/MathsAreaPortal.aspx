<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MathsAreaPortal.aspx.cs" Inherits="MathsAreaPortal" %>

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
            Calculate the Area for Circel: 
            <br />
            <br />
             Enter the radius: 
        <asp:TextBox ID="txt_Radius" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Circle" runat="server" Text="Circle Area" OnClick="btn_Circle_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Circle" runat="server" Text="Circle Area Output"></asp:Label>
            <br />
            <br />
            Calculate the Area for Rectangle: 
            <br />
            <br />
             Enter the Height: 
        <asp:TextBox ID="txt_Height" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Width: 
        <asp:TextBox ID="txt_Width" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Rectangle" runat="server" Text="Rectangle Area" OnClick="btn_Rectangle_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Rectangle" runat="server" Text="Rectangle Area Output"></asp:Label>
            <br />
            <br />
            Calculate the Area for Triangle: 
            <br />
            <br />
             Enter the Height: 
        <asp:TextBox ID="txt_THeight" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Base: 
        <asp:TextBox ID="txt_TBase" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Triangle" runat="server" Text="Triangle Area" OnClick="btn_Triangle_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Triangle" runat="server" Text="Triangle Area Output"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
