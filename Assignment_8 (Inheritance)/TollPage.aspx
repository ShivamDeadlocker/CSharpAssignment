<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TollPage.aspx.cs" Inherits="TollPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Details of your Vehicale:
        <br />
            <br />
            Enter the vehicale number:
        <asp:TextBox ID="txt_cnumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the customer cname:
        <asp:TextBox ID="txt_cname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Car" runat="server" Text="Toll Price for Car " OnClick="btn_Car_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Truck" runat="server" Text="Toll Price for Truck " OnClick="btn_Truck_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Bus" runat="server" Text="Toll Price for bus " OnClick="btn_Bus_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Car" runat="server" Text="Toll Information for Car"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Truck" runat="server" Text="Toll Information for Truck"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Bus" runat="server" Text="Toll Information for Bus"></asp:Label>
        </div>
    </form>
</body>
</html>
