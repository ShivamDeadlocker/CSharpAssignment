using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Calculate_Click(object sender, EventArgs e)
    {
        double r1 = -1 + 4 * 6;
        double r2 = (35 + 5) % 7;
        double r3 = 14 + -4 * 6 / 11;
        double r4 = 2 + 15 / 6 * 1 - 7 % 2;

        lbl_Section1.Text = r1.ToString() + "<br/>" + r2.ToString() + "<br/>" + r3.ToString() + "<br/>" + r4.ToString() + "<br/>";


    }

    protected void btn_Swap_Click(object sender, EventArgs e)
    {
        int num1 = 6;
        int num2 = 5;

        int temp = num1;
        num1 = num2;
        num2 = temp;

        lbl_Section2.Text = num1.ToString() + " " + num2.ToString();
    }

    protected void btn_Average_Click(object sender, EventArgs e)
    {
        double num1, num2, num3, num4, result;

        num1 = Convert.ToInt32(txt_num1.Text);
        num2 = Convert.ToInt32(txt_num2.Text);
        num3 = Convert.ToInt32(txt_num3.Text);
        num4 = Convert.ToInt32(txt_num4.Text);

        result = (num1 + num2 + num3 + num4) / 4;
        lbl_Average.Text = result.ToString();

        Console.WriteLine("abc ");

    }
}