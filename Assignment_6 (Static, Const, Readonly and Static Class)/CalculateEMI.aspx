<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalculateEMI.aspx.cs" Inherits="CalculateEMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Principal Amount:
            <asp:TextBox ID="txt_Principal" runat="server" Placeholder="Enter Your Principal Amount"></asp:TextBox>
            <br />
            <br />
            Enter Rate of Intrest:
            <asp:TextBox ID="txt_Rate" runat="server" Placeholder="Enter ROI"></asp:TextBox>
            <br />
            <br />
            Enter The Number of Months :
            <asp:TextBox ID="txt_Month" runat="server" Placeholder="Enter Number of Months"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_EMI" runat="server" Text="Get Your EMI " OnClick="btn_EMI_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_EMI_Info" runat="server" Text="EMI Info"></asp:Label>

        </div>
    </form>
</body>
</html>
