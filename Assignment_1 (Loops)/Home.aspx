<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td colspan="3">Q1. Arihmetic Operations
                    </td>
                </tr>
                <tr>
                    <td>1)-1 + 4 * 6 
                        <br />
                        2)( 35+ 5 ) % 7
                                                <br />

                        3)14 + -4 * 6 / 11
                                                <br />

                        4)2 + 15 / 6 * 1 - 7 % 2
                                                <br />

                    </td>
                    <td>
                        <asp:Label ID="lbl_Section1" runat="server" Text="Output"></asp:Label></td>
                    <td>
                        <asp:Button ID="btn_Q1" runat="server" Text="Calculate" OnClick="btn_Calculate_Click" /></td>
                </tr>
                <tr>
                    <td>Q.2 Swap Two Number [6, 5]</td>
                    <td>
                        <asp:Label ID="lbl_Section2" runat="server" Text="Output"></asp:Label></td>
                    <td>
                        <asp:Button ID="btn_Q2" runat="server" Text="Calculate" OnClick="btn_Swap_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Q.3 Calculate Average</td>
                    <td>Num1:&nbsp;<asp:TextBox ID="txt_num1" runat="server"></asp:TextBox>&nbsp;Num2:&nbsp;<asp:TextBox ID="txt_num2" runat="server"></asp:TextBox>&nbsp;Num3:&nbsp;<asp:TextBox ID="txt_num3" runat="server"></asp:TextBox>&nbsp;Num4:&nbsp;<asp:TextBox ID="txt_num4" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_Average" runat="server" Text="Average" OnClick="btn_Average_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>Average:&nbsp;<asp:Label ID="lbl_Average" runat="server" Text="Average"></asp:Label></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
