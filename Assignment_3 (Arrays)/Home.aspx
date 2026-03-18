<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 413px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <table style="width: 100%; border-spacing: 0 10px;">

                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lbl_ReferenceArray" runat="server" Text="Reference Array"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_InputArray" runat="server" Text="lbl_Original_Array"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="btn_Reverse_Click" Text="Reversing_Array " />
                    </td>
                    <td>
                        <asp:Label ID="lbl_Reversing_Array1" runat="server" Text="Reversing_Array: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Reversed_Array" runat="server" Text="lbl_Reversing_Array_Output"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_SumArrayElements" runat="server" OnClick="btn_Sum_Click" Text="Sum_Array_Elements" />
                    </td>
                    <td>
                        <asp:Label ID="lbl_SumofArray" runat="server" Text="SumofArray: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_SumofArrayElementOutput" runat="server" Text="lbl_SumofArrayElementOutput"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Copy" runat="server" OnClick="btn_Copy_Click" Text="Copy_Array_Elements" />
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="New Array: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_NewArrayElementOutput" runat="server" Text="lbl_NewArrayElement"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Duplicate" runat="server" OnClick="btn_Duplicate_Click" Text="Count_Duplicate_Array_Elements" />
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Count: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_CountDuplicateArrayElementOutput" runat="server" Text="lbl_CountDuplicateArrayElement"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Merged" runat="server" OnClick="btn_Merged_Click" Text="Merged_Array" />
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Merged Array: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Merged_Array_Output" runat="server" Text="lbl_Merged_Array"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_CountFrequency" runat="server" OnClick="btn_CountFrequency_Click" Text="Count_Elements" />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Frequency: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Frequency_Output" runat="server" Text="lbl_Frequency"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Max_Min_Array" runat="server" OnClick="btn_FindMaxMin_Click" Text="Max_Min_Array" />
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Max Element: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Max_Output" runat="server" Text="lbl_Max"></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label7" runat="server" Text="Min Element: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Min_Output" runat="server" Text="lbl_Min"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_EvenOdd" runat="server" OnClick="btn_EvenOdd_Click" Text="Even_Odd_Array" />
                    </td>

                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Even Array: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_EvenArray_Output" runat="server" Text="lbl_EvenArray"></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label9" runat="server" Text="Odd Array:: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_OddArray_Output" runat="server" Text="lbl_OddArray"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_Ascending" runat="server" OnClick="btn_Ascending_Click" Text="Elements_InAscending" />
                    </td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Elements_Ascending: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_Elements_Ascending_Output" runat="server" Text="lbl_Elements_Ascending"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" OnClick="btn_SecondSmallest_Click" Text="SecondSmallest_Element" />
                    </td>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Second Smallest Element: "></asp:Label>
                        &nbsp;
                    <asp:Label ID="lbl_SecondSmallest_Element_Output" runat="server" Text="lbl_SecondSmallest_Element"></asp:Label>
                    </td>
                </tr>

            </table>

        </div>
    </form>
</body>
</html>
