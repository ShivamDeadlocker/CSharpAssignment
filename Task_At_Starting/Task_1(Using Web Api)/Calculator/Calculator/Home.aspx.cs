using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MathLib;

namespace Calculator
{
    public partial class Home : System.Web.UI.Page
    {
        int x, y, z;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextNum1.Text);
            y = Convert.ToInt32(txt_num2.Text);

            MathLib.Calculator m = new MathLib.Calculator();

            z = m.Add(x, y);

            lbl_result.Text = z.ToString();



        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextNum1.Text);
            y = Convert.ToInt32(txt_num2.Text);

            MathLib.Calculator m = new MathLib.Calculator();

            z = m.Sub(x, y);

            lbl_result.Text = z.ToString();
        }



        protected void Mul_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextNum1.Text);
            y = Convert.ToInt32(txt_num2.Text);

            MathLib.Calculator m = new MathLib.Calculator();

            z = m.Mul(x, y);

            lbl_result.Text = z.ToString();
        }

        protected void Div_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextNum1.Text);
            y = Convert.ToInt32(txt_num2.Text);

            MathLib.Calculator m = new MathLib.Calculator();

            z = m.Div(x, y);

            lbl_result.Text = z.ToString();
        }

 
    }
}