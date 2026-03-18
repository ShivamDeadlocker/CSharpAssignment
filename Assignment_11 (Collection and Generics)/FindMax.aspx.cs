using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// This web page is used for Finding the max between two values , values can be float, int , double
/// </summary>
public partial class FindMax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Max_Click(object sender, EventArgs e)
    {
        try
        {
            lbl_Max.Text = Convert.ToString(FindMaxNumber<int>(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text)));
            //lbl_Max.Text = Convert.ToString(FindMaxNumber<double>(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text)));
            //lbl_Max.Text = Convert.ToString(FindMaxNumber<float>(float.Parse(txt_num1.Text), float.Parse(txt_num2.Text)));
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Generic Method For Finding the Max 
    public T FindMaxNumber<T>(T num1, T num2)
    {
        dynamic a = num1;
        dynamic b = num2;

        if (a > b)
        {
            return a;
        }
        else {
            return b;
        }
    }

}