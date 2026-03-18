<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="grid_Products" runat="server"></asp:GridView>
        </div>

        <br />
        <br />
        <div>
            <h2>Select the Products: </h2>
            <asp:DropDownList ID="ddl_Product" runat="server"></asp:DropDownList>
        </div>
            <br />
            <br />
        <div>

            Enter Quantity:
            <asp:TextBox ID="txt_Quantity" runat="server"></asp:TextBox>
            <br />
            <br />


            Enter Money:
            <asp:TextBox ID="txt_Money" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btn_Buy" runat="server"
                Text="Buy"
                OnClick="btn_Buy_Click" />

            <br />
            <br />

            <asp:Label ID="lbl_Result" runat="server" ForeColor="Green"></asp:Label>

        </div>

    </form>
</body>
</html>
