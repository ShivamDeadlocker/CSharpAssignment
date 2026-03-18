<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OverTheTop.aspx.cs" Inherits="OverTheTop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Details of your OTT Plan:
        <br />
            <br />
            Enter the User Name:
        <asp:TextBox ID="txt_UserName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Duration (months) :
        <asp:TextBox ID="txt_Duration" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_BasicPlan" runat="server" Text="Basic Plan" OnClick="btn_BasicPlan_Click" />
            <br />
            <br />
            <asp:Button ID="btn_PremiumPlan" runat="server" Text="Premium Plan" OnClick="btn_PremiumPlan_Click" />
            <br />
            <br />
            <asp:Button ID="btn_FamilyPlan" runat="server" Text="Family Plan" OnClick="btn_FamilyPlan_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_BasicPlan" runat="server" Text="Basic Plan Charges"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_PremiumPlan" runat="server" Text="Premium Plan Charges"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_FamilyPlan" runat="server" Text="Family Plan Charges"></asp:Label>
        </div>
    </form>
</body>
</html>
