using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECommerce;

/// <summary>
/// This web page show different paymenet mode using delegates
/// </summary>
public partial class Home : System.Web.UI.Page
{
    //Refrence variable of reference class and Delegates 
    CommonPaymentService cps;
    PaymentMethods pm;
    PaymentModule dpm; // Delegates reference


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Creating the object of CommonPaymentService, PaymentMethods
    public void setPayMode()
    {
        cps = new CommonPaymentService();
        pm = new PaymentMethods();
    }


    //This will  run credit card payment method
    protected void btn_CPay_Click(object sender, EventArgs e)
    {
        try
        {
            setPayMode();
            PaymentModule dpm = new PaymentModule(pm.CreditCard);
            lbl_Pay_Output.Text = cps.Pay(1000, dpm);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This will run UPI card payment method
    protected void btn_UPay_Click(object sender, EventArgs e)
    {
        try
        {
            setPayMode();
            dpm = new PaymentModule(pm.UPI);
            lbl_Pay_Output.Text = cps.Pay(1000, dpm);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This will run Net Banking payment method
    protected void btn_NPay_Click(object sender, EventArgs e)
    {
        try
        {
            setPayMode();
            dpm = new PaymentModule(pm.NetBanking);

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}