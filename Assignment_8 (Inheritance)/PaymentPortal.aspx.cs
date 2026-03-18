using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentGateway;


public partial class PaymentPortal : System.Web.UI.Page
{

    string trid;
    double tamount;

    //Reading the input from the user
    public void readValue()
    {
        trid = txt_trid.Text;
        tamount = Convert.ToDouble(txt_tamount.Text);
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Payment system using Credit Card 
    protected void btn_CreditCardPayment_Click(object sender, EventArgs e)
    {

        try
        {
            readValue();

            PaymentSystem cr = new CreditCardPayment(trid, tamount);
            cr.CalculateProcessingFees();
            lbl_CreditCardPayment.Text = cr.TransactionId + " " + cr.Amount + " " + cr.paymentDate + " " + cr.ProcessingFees;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }


    //Payment system using UPI
    protected void btn_UPIPayment_Click(object sender, EventArgs e)
    {

        try
        {
            readValue();

            PaymentSystem upi = new UPIPayment(trid, tamount);
            upi.CalculateProcessingFees();
            lbl_UPIPayment.Text = upi.TransactionId + " " + upi.Amount + " " + upi.paymentDate + " " + upi.ProcessingFees;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }


    //Payment system using NetBanking
    protected void btn_NetBanking_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            PaymentSystem nbp = new NetBankingPayment(trid, tamount);
            nbp.CalculateProcessingFees();
            lbl_NetBankingPayment.Text = nbp.TransactionId + " " + nbp.Amount + " " + nbp.paymentDate + " " + nbp.ProcessingFees;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}