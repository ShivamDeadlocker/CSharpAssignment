<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WatchShop.aspx.cs" Inherits="WatchShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Smart Watch Features:
            <br />
            <br />
            <asp:Button ID="btn_Fitness" runat="server" Text="Fitness Check" OnClick="btn_Fitness_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Bluetooth" runat="server" Text="Check Bluetooth Connectivity" OnClick="btn_Bluetooth_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Notification" runat="server" Text="Check Notification" OnClick="btn_Notification_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Fitness" runat="server" Text="Fitness Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Bluetooth" runat="server" Text="Bluetooth Information"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_Notification" runat="server" Text="Notification Information"></asp:Label>
        </div>
    </form>
</body>
</html>
