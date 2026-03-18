<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <form id="form2" runat="server">

    <div>
      <table style="width: 100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Enter 1st Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_num1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Enter 2nd Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_num2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_result" runat="server" Text="Result"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Operations"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Add_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Sub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Mul_Click" Text="Mul" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Div_Click" Text="Div" Width="55px" />
                 </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="Reset" />
                 </td>
            </tr>
        </table>
    </div>
    </form>
    </div>
    </form>
</body>
</html>
