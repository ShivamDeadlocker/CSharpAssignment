using System;
using System.Web.UI;
using EMI;

/// <summary>
/// Web page used to calculate EMI based on principal amount,
/// interest rate and loan tenure.
/// </summary>
public partial class CalculateEMI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Handles EMI calculation when the button is clicked.
    /// </summary>
    protected void btn_EMI_Click(object sender, EventArgs e)
    {
        try
        {
            // Read input values from textboxes
            double principal = Convert.ToDouble(txt_Principal.Text);
            double rate = Convert.ToDouble(txt_Rate.Text);
            int months = Convert.ToInt32(txt_Month.Text);

            // Call EMI calculation method from class library
            double emi = EMI.CalculateEMI.Calculate(principal, rate, months);

            // Display EMI result
            lbl_EMI_Info.Text = "Your EMI is " + Math.Round(emi, 2);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}