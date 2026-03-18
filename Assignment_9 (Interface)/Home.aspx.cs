using System;
using System.Web.UI;
using WatchStore;

/// <summary>
/// Web UI page for selecting payment method in Watch Store.
/// Demonstrates interface based payment processing.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    // Interface reference for different payment types
    IPayment payment;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Displays payment information on the screen.
    /// </summary>
    public void SetOutput(ProcessPaymentService pr)
    {
        try
        {
            lbl_Amount.Text = Convert.ToString(pr.Amount);

            // Calling service methods
            lbl_Validate.Text = pr.Validate();
            lbl_Process.Text = pr.Process();
            lbl_Receipt.Text = pr.Generate();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Handles Credit Card payment process
    /// </summary>
    protected void btn_Credit_Card_Click(object sender, EventArgs e)
    {
        try
        {
            // Creating Credit Card payment object
            payment = new CreditCard();

            // Injecting payment object into ProcessPaymentService
            ProcessPaymentService cr = new ProcessPaymentService(1000, payment);

            SetOutput(cr);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Handles UPI payment process
    /// </summary>
    protected void btn_UPI_Click(object sender, EventArgs e)
    {
        try
        {
            payment = new UpiPayment();

            ProcessPaymentService upi = new ProcessPaymentService(2000, payment);

            SetOutput(upi);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Handles NetBanking payment process
    /// </summary>
    protected void btn_NetBanking_Click(object sender, EventArgs e)
    {
        try
        {
            payment = new NetBanking();

            ProcessPaymentService nb = new ProcessPaymentService(1000, payment);

            SetOutput(nb);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}