<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Account Holder Name:
            <asp:TextBox ID="txt_AName" runat="server" Placeholder="Enter Your Name"></asp:TextBox>
            <br />
            <br />
            Enter Account Number:
            <asp:TextBox ID="txt_ANumber" runat="server" Placeholder="Enter Your Account Number"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Account" runat="server" Text="Get Account Info" OnClick="btn_Account_Info_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Account_Info" runat="server" Text="Account Info"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_GST" runat="server" Text="Go To GST Calculation" OnClick="btn_GST_Page_Click" />
        </div>
    </form>
</body>
</html>
