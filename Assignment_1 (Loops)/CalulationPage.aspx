<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalulationPage.aspx.cs" Inherits="CalulationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form" runat="server">

        <h2>Assignment 1 - Loops</h2>

        <table border="1" style="width:100%; padding:10px">

            <!-- Q1 -->
            <tr>
                <td>Q1 Arithmetic Operations</td>
                <td>
                    <asp:Label ID="lbl_Q1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Q1" runat="server" Text="Run" OnClick="btn_Q1_Click" />
                </td>
            </tr>

            <!-- Q2 -->
            <tr>
                <td>Q2 Swap Two Numbers</td>
                <td>
                    <asp:Label ID="lbl_Q2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Swap" runat="server" Text="Run" OnClick="btn_Swap_Click" />
                </td>
            </tr>

            <!-- Q3 Average -->
            <tr>
                <td>Q3 Average of Four Numbers</td>
                <td>
                    Num1 <asp:TextBox ID="txt_num1" runat="server"></asp:TextBox>
                    Num2 <asp:TextBox ID="txt_num2" runat="server"></asp:TextBox>
                    Num3 <asp:TextBox ID="txt_num3" runat="server"></asp:TextBox>
                    Num4 <asp:TextBox ID="txt_num4" runat="server"></asp:TextBox>
                    <br />
                    Average :
                    <asp:Label ID="lbl_Average" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Average" runat="server" Text="Calculate" OnClick="btn_Average_Click" />
                </td>
            </tr>

            <!-- Q4 -->
            <tr>
                <td>Q4 Rectangle Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Rectangle" runat="server" Text="Run" OnClick="btn_Rectangle_Click" />
                </td>
            </tr>

            <!-- Q5 -->
            <tr>
                <td>Q5 Positive Negative Check</td>
                <td>
                    <asp:Label ID="lbl_Q5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_PosNeg" runat="server" Text="Run" OnClick="btn_PosNeg_Click" />
                </td>
            </tr>

            <!-- Q6 -->
            <tr>
                <td>Q6 Triple Sum</td>
                <td>
                    <asp:Label ID="lbl_Q6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_TripleSum" runat="server" Text="Run" OnClick="btn_TripleSum_Click" />
                </td>
            </tr>

            <!-- Q7 -->
            <tr>
                <td>Q7 Check Sum 20</td>
                <td>
                    <asp:Label ID="lbl_Q7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Check20" runat="server" Text="Run" OnClick="btn_Check20_Click" />
                </td>
            </tr>

            <!-- Q8 -->
            <tr>
                <td>Q8 Reverse Sentence</td>
                <td>
                    <asp:Label ID="lbl_Q8" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Reverse" runat="server" Text="Run" OnClick="btn_Reverse_Click" />
                </td>
            </tr>

            <!-- Q9 -->
            <tr>
                <td>Q9 Sum of First 10 Natural Numbers</td>
                <td>
                    <asp:Label ID="lbl_Q9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Sum10" runat="server" Text="Run" OnClick="btn_Sum10_Click" />
                </td>
            </tr>

            <!-- Q10 -->
            <tr>
                <td>Q10 Display N Natural Numbers</td>
                <td>
                    <asp:Label ID="lbl_Q10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_NNumbers" runat="server" Text="Run" OnClick="btn_NNumbers_Click" />
                </td>
            </tr>

            <!-- Q11 -->
            <tr>
                <td>Q11 Sum and Average of 10 Numbers</td>
                <td>
                    <asp:Label ID="lbl_Q11" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_SumAvg" runat="server" Text="Run" OnClick="btn_SumAvg_Click" />
                </td>
            </tr>

            <!-- Q12 -->
            <tr>
                <td>Q12 Cube of Numbers</td>
                <td>
                    <asp:Label ID="lbl_Q12" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Cube" runat="server" Text="Run" OnClick="btn_Cube_Click" />
                </td>
            </tr>

            <!-- Q13 -->
            <tr>
                <td>Q13 Star Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q13" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Star" runat="server" Text="Run" OnClick="btn_Star_Click" />
                </td>
            </tr>

            <!-- Q14 -->
            <tr>
                <td>Q14 Number Triangle</td>
                <td>
                    <asp:Label ID="lbl_Q14" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_NumTriangle" runat="server" Text="Run" OnClick="btn_NumTriangle_Click" />
                </td>
            </tr>

            <!-- Q15 -->
            <tr>
                <td>Q15 Repeat Number Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q15" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_RepeatNum" runat="server" Text="Run" OnClick="btn_RepeatNum_Click" />
                </td>
            </tr>

            <!-- Q16 -->
            <tr>
                <td>Q16 Increasing Number Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q16" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_IncreaseNum" runat="server" Text="Run" OnClick="btn_IncreaseNum_Click" />
                </td>
            </tr>

            <!-- Q17 -->
            <tr>
                <td>Q17 Pyramid Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q17" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Pyramid" runat="server" Text="Run" OnClick="btn_Pyramid_Click" />
                </td>
            </tr>

            <!-- Q18 -->
            <tr>
                <td>Q18 121 Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q18" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_121" runat="server" Text="Run" OnClick="btn_121_Click" />
                </td>
            </tr>

            <!-- Q19 -->
            <tr>
                <td>Q19 Palindrome Number</td>
                <td>
                    <asp:Label ID="lbl_Q19" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Palindrome" runat="server" Text="Run" OnClick="btn_Palindrome_Click" />
                </td>
            </tr>

            <!-- Q20 -->
            <tr>
                <td>Q20 Alphabet Pattern</td>
                <td>
                    <asp:Label ID="lbl_Q20" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Alphabet" runat="server" Text="Run" OnClick="btn_Alphabet_Click" />
                </td>
            </tr>

            <!-- Q21 -->
            <tr>
                <td>Q21 HCF</td>
                <td>
                    <asp:Label ID="lbl_Q21" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_HCF" runat="server" Text="Run" OnClick="btn_HCF_Click" />
                </td>
            </tr>

            <!-- Q22 -->
            <tr>
                <td>Q22 LCM</td>
                <td>
                    <asp:Label ID="lbl_Q22" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_LCM" runat="server" Text="Run" OnClick="btn_LCM_Click" />
                </td>
            </tr>

        </table>

    </form>
</body>
</html>
