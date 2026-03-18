using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecommerce;

/// <summary>
/// Web page used to calculate the shipping charges for different types product
/// like Online Products and Store Products.
/// </summary>
public partial class ShippingCharges : System.Web.UI.Page
{
    int id;
    string cname;
    double amount;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Reading the input from the user
    public void readValue()
    {
        id = Convert.ToInt32(txt_ProId.Text);
        cname = txt_CustName.Text;
        amount = Convert.ToDouble(txt_Amount.Text);
    }

    //Calculating the shipping charges for online product
    protected void btn_Online_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Order ord = new OnlineOrder(id, cname, amount);
            ord.CalculateAmount(ord.OrderAmount);
            lbl_Online.Text = ord.OrderId + " " + ord.CustomerName + " " + ord.OrderAmount + " " + ord.FinalAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Calculating the shipping charges for store product
    protected void btn_Store_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Order sorder = new StoreOrder(id, cname, amount);
            sorder.CalculateAmount(sorder.OrderAmount);
            lbl_Store.Text = sorder.OrderId + " " + sorder.CustomerName + " " + sorder.OrderAmount + " " + sorder.FinalAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }


}