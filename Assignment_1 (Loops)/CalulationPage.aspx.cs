using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalulationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region Q1 to Q10
    /// <summary>
    /// Q1 Arithmetic Operations
    /// </summary>
    protected void btn_Q1_Click(object sender, EventArgs e)
    {
        try
        {
            int r1 = -1 + 4 * 6;
            int r2 = (35 + 5) % 7;
            int r3 = 14 + -4 * 6 / 11;
            int r4 = 2 + 15 / 6 * 1 - 7 % 2;

            lbl_Q1.Text = r1 + "<br/>" + r2 + "<br/>" + r3 + "<br/>" + r4;
        }
        catch (Exception ex)
        {
            lbl_Q1.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q2 Swap Two Numbers
    /// </summary>
    protected void btn_Swap_Click(object sender, EventArgs e)
    {
        try
        {
            int num1 = 6;
            int num2 = 5;

            int temp = num1;
            num1 = num2;
            num2 = temp;

            lbl_Q2.Text = num1 + " " + num2;
        }
        catch (Exception ex)
        {
            lbl_Q2.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q3 Average of Four Numbers
    /// </summary>
    protected void btn_Average_Click(object sender, EventArgs e)
    {
        try
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);
            double num3 = Convert.ToDouble(txt_num3.Text);
            double num4 = Convert.ToDouble(txt_num4.Text);

            double result = (num1 + num2 + num3 + num4) / 4;

            lbl_Average.Text = result.ToString();
        }
        catch (Exception ex)
        {
            lbl_Average.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q4 Rectangle Pattern
    /// </summary>
    protected void btn_Rectangle_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            result += "555<br/>";
            result += "5&nbsp;5<br/>";
            result += "5&nbsp;5<br/>";
            result += "5&nbsp;5<br/>";
            result += "555";

            lbl_Q4.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q4.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q5 Positive Negative Check
    /// </summary>
    protected void btn_PosNeg_Click(object sender, EventArgs e)
    {
        try
        {
            int a = -5;
            int b = 10;

            bool result = (a < 0 && b > 0) || (a > 0 && b < 0);

            lbl_Q5.Text = result.ToString();
        }
        catch (Exception ex)
        {
            lbl_Q5.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q6 Triple Sum if Equal
    /// </summary>
    protected void btn_TripleSum_Click(object sender, EventArgs e)
    {
        try
        {
            int a = 5;
            int b = 5;

            int result;

            if (a == b)
                result = (a + b) * 3;
            else
                result = a + b;

            lbl_Q6.Text = result.ToString();
        }
        catch (Exception ex)
        {
            lbl_Q6.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q7 Check if number is 20 or sum is 20
    /// </summary>
    protected void btn_Check20_Click(object sender, EventArgs e)
    {
        try
        {
            int a = 10;
            int b = 10;

            bool result = (a == 20 || b == 20 || (a + b) == 20);

            lbl_Q7.Text = result.ToString();
        }
        catch (Exception ex)
        {
            lbl_Q7.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q8 Reverse Sentence
    /// </summary>
    protected void btn_Reverse_Click(object sender, EventArgs e)
    {
        try
        {
            string sentence = "Welcome To DotNet";

            string[] words = sentence.Split(' ');

            Array.Reverse(words);

            lbl_Q8.Text = string.Join(" ", words);
        }
        catch (Exception ex)
        {
            lbl_Q8.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q9 Sum of first 10 natural numbers
    /// </summary>
    protected void btn_Sum10_Click(object sender, EventArgs e)
    {
        try
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
                sum += i;

            lbl_Q9.Text = sum.ToString();
        }
        catch (Exception ex)
        {
            lbl_Q9.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q10 Display N numbers and their sum
    /// </summary>
    protected void btn_NNumbers_Click(object sender, EventArgs e)
    {
        try
        {
            int n = 5;
            int sum = 0;
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += i + " ";
                sum += i;
            }

            lbl_Q10.Text = result + "<br/>Sum = " + sum;
        }
        catch (Exception ex)
        {
            lbl_Q10.Text = ex.Message;
        }
    }

    #endregion

    #region Q11 to Q20
    /// <summary>
    /// Q11 Sum and average of 10 numbers
    /// </summary>
    protected void btn_SumAvg_Click(object sender, EventArgs e)
    {
        try
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int sum = 0;

            foreach (int num in arr)
                sum += num;

            double avg = sum / 10.0;

            lbl_Q11.Text = "Sum = " + sum + "<br/>Average = " + avg;
        }
        catch (Exception ex)
        {
            lbl_Q11.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q12 Cube of numbers
    /// </summary>
    protected void btn_Cube_Click(object sender, EventArgs e)
    {
        try
        {
            int n = 5;
            string result = "";

            for (int i = 1; i <= n; i++)
                result += "Cube of " + i + " = " + (i * i * i) + "<br/>";

            lbl_Q12.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q12.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q13 Star Pattern
    /// </summary>
    protected void btn_Star_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    result += "*";

                result += "<br/>";
            }

            lbl_Q13.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q13.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q14 Number Triangle
    /// </summary>
    protected void btn_NumTriangle_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    result += j;

                result += "<br/>";
            }

            lbl_Q14.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q14.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q15 Repeat Number Pattern
    /// </summary>
    protected void btn_RepeatNum_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    result += i;

                result += "<br/>";
            }

            lbl_Q15.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q15.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q16 Increasing Number Pattern
    /// </summary>
    protected void btn_IncreaseNum_Click(object sender, EventArgs e)
    {
        try
        {
            int num = 1;
            string result = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += num + " ";
                    num++;
                }

                result += "<br/>";
            }

            lbl_Q16.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q16.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q17 Pyramid Pattern
    /// </summary>
    protected void btn_Pyramid_Click(object sender, EventArgs e)
    {
        try
        {
            int num = 1;
            string result = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int s = 4; s > i; s--)
                    result += "&nbsp;";

                for (int j = 1; j <= i; j++)
                {
                    result += num + " ";
                    num++;
                }

                result += "<br/>";
            }

            lbl_Q17.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q17.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q18 121 Pattern
    /// </summary>
    protected void btn_121_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                    result += j;

                for (int j = i - 1; j >= 1; j--)
                    result += j;

                result += "<br/>";
            }

            lbl_Q18.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q18.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q19 Palindrome Number
    /// </summary>
    protected void btn_Palindrome_Click(object sender, EventArgs e)
    {
        try
        {
            int num = 121;
            int original = num;
            int reverse = 0;

            while (num > 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }

            lbl_Q19.Text = (original == reverse) ? "Palindrome" : "Not Palindrome";
        }
        catch (Exception ex)
        {
            lbl_Q19.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q20 Alphabet Pattern
    /// </summary>
    protected void btn_Alphabet_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                    result += (char)('A' + j) + " ";

                for (int j = i - 1; j >= 0; j--)
                    result += (char)('A' + j) + " ";

                result += "<br/>";
            }

            lbl_Q20.Text = result;
        }
        catch (Exception ex)
        {
            lbl_Q20.Text = ex.Message;
        }
    }

    #endregion

    #region Q21 to Q22
    /// <summary>
    /// Q21 HCF
    /// </summary>
    protected void btn_HCF_Click(object sender, EventArgs e)
    {
        try
        {
            int a = 24;
            int b = 28;

            int hcf = 1;

            for (int i = 1; i <= a && i <= b; i++)
                if (a % i == 0 && b % i == 0)
                    hcf = i;

            lbl_Q21.Text = "HCF = " + hcf;
        }
        catch (Exception ex)
        {
            lbl_Q21.Text = ex.Message;
        }
    }

    /// <summary>
    /// Q22 LCM
    /// </summary>
    protected void btn_LCM_Click(object sender, EventArgs e)
    {
        try
        {
            int a = 15;
            int b = 20;

            int max = (a > b) ? a : b;

            while (true)
            {
                if (max % a == 0 && max % b == 0)
                {
                    lbl_Q22.Text = "LCM = " + max;
                    break;
                }

                max++;
            }
        }
        catch (Exception ex)
        {
            lbl_Q22.Text = ex.Message;
        }
    }
    #endregion
}