using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathLib;


public partial class Home : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    int result;

    //This method is used for returning the  array which consist the user number input
    private int [] GetNumbers()
    {
        int x = Convert.ToInt32(txt_num1.Text);
        int y = Convert.ToInt32(txt_num2.Text);
        return new int[] { x, y };
    }

    //This method is used for adding the two numbers
    protected void Add_Click(object sender, EventArgs e)
    {
        try
        {
            var numbers = GetNumbers();

            MathLib.Calculator m = new MathLib.Calculator();

            result = m.Add(numbers[0], numbers[1]);

            lbl_result.Text = result.ToString();

        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }


    }

    //This method is used for subtarcting the two numbers
    protected void Sub_Click(object sender, EventArgs e)
    {
        try
        {
      
            var numbers = GetNumbers();
            MathLib.Calculator m = new MathLib.Calculator();
            result = m.Sub(numbers[0], numbers[1]);
            lbl_result.Text = result.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This method is used for multiplying the two numbers
    protected void Mul_Click(object sender, EventArgs e)
    {
        try
        {
            var numbers = GetNumbers();
            MathLib.Calculator m = new MathLib.Calculator();
            result = m.Mul(numbers[0], numbers[1]);
            lbl_result.Text = result.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This method is used for dividing the two numbers
    protected void Div_Click(object sender, EventArgs e)
    {
        try
        {
            var numbers = GetNumbers();
            MathLib.Calculator m = new MathLib.Calculator();
            result = m.Div(numbers[0], numbers[1]);
            lbl_result.Text = result.ToString();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}