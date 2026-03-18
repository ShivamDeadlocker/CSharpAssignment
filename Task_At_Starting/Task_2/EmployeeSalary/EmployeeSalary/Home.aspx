<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EmployeeSalary.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 214px;
        }
        .auto-style2 {
            width: 214px;
            height: 26px;
        }
        .auto-style4 {
            width: 196px;
        }
        .auto-style5 {
            height: 26px;
            width: 196px;
        }
        .auto-style6 {
            width: 214px;
            height: 28px;
        }
        .auto-style7 {
            height: 28px;
            width: 196px;
        }
        .auto-style9 {
            width: 100%;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Enter EmpID"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_EmpId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Enter EmpName"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_EmpName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Enter Basic Salary"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_BasicSalary" runat="server"></asp:TextBox>
                </td>
            </tr>

                        <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Enter Your PF"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_PF" runat="server"></asp:TextBox>
                            </td>
            </tr>

                        <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Enter Your DA"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txt_DA" runat="server"></asp:TextBox>
                            </td>
            </tr>

                        <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Enter Your HRA"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_HRA" runat="server"></asp:TextBox>
                            </td>
            </tr>

                                    <tr>
                <td class="auto-style1">
                </td>
                <td class="auto-style4">
                            <asp:Button ID="btn_calculate" runat="server" Text="Calculate" OnClick="Calculate_Click" />
                            </td>
            </tr>
        </table>
    
    </div>
        <div>
          <h3>EmpId:  <asp:Label ID="lbl_Company" runat="server" Text="lbl_Company" Visible="False"></asp:Label></h3> 

          <h3>EmpId:  <asp:Label ID="lbl_EmpId" runat="server" Text="lbl_EmpID" Visible="False"></asp:Label></h3> 

          <h3>EmpName:  <asp:Label ID="lbl_EmpName" runat="server" Text="lbl_EmpName" Visible="False"></asp:Label></h3> 

          <h3>Net Salary:  <asp:Label ID="lab_result" runat="server" Text="lbl_Netsal" Visible="False"></asp:Label></h3> 
        </div>
        
    </form>
</body>
</html>
