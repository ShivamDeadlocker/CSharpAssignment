using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderDetails;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Order_Click(object sender, EventArgs e)
    {
        Order ord = new Order();

        ord = ord.PlaceOrder(Convert.ToInt32(txt_TotalAmount.Text), Convert.ToInt32(txt_OrderNumber.Text));

        lbl_Output.Text = " " + ord.TotalAmount + " " + ord.OrderNumber;
    }
}