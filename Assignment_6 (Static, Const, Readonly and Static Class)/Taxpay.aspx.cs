using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using GST;

/// <summary>
/// Web page used to calculate GST and display the final payable amount.
/// </summary>
public partial class Taxpay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Calculates tax and total payable amount when button is clicked.
    /// </summary>
    protected void btn_Tax_Info_Click(object sender, EventArgs e)
    {
        try
        {
            // Variable to store final amount after adding GST
            double totalPay;

            // Call tax calculation method from GST class
            double tax = GST.TaxCalculation.Bill(
                Convert.ToInt32(txt_Money.Text),
                out totalPay
            );

            // Display tax and total payable amount
            lbl_Tax_Info.Text =
                "Your Tax: " + tax +
                "<br />Your total payable amount: " + totalPay;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}