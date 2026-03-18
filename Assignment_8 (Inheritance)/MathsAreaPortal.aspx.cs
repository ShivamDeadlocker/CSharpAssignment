using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShapeClass;

/// <summary>
/// Web page used to calculate the Area for diffrent shapes
/// like Rectangle, Triangle and Circle.
/// </summary>
public partial class MathsAreaPortal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Calculate the Area for Rectangle
    protected void btn_Rectangle_Click(object sender, EventArgs e)
    {
        try
        {
            Shape rec = new Rectangle(btn_Rectangle.Text.TrimEnd('A', 'r', 'e', 'a'), Convert.ToDouble(txt_Height.Text), Convert.ToDouble(txt_Width.Text));
            rec.CalculateArea();
            lbl_Rectangle.Text = rec.ShapeName + " " + rec.CalculatedArea;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Calculate the Area for Triangle
    protected void btn_Triangle_Click(object sender, EventArgs e)
    {
        try
        {
            Shape tr = new Triangle(btn_Triangle.Text.TrimEnd('A', 'r', 'e', 'a'), Convert.ToDouble(txt_TBase.Text), Convert.ToDouble(txt_THeight.Text));
            tr.CalculateArea();
            lbl_Triangle.Text = tr.ShapeName + " " + tr.CalculatedArea;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Calculate the Area for Circle
    protected void btn_Circle_Click(object sender, EventArgs e)
    {
        try
        {
            Shape cr = new Circle(btn_Circle.Text.TrimEnd('A', 'r', 'e', 'a'), Convert.ToDouble(txt_Radius.Text));
            cr.CalculateArea();
            lbl_Circle.Text = cr.ShapeName + " " + cr.CalculatedArea;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}