using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankingApplication;

/// <summary>
/// Web page used to create a bank account object and
/// display account holder details.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates an Account object and displays account information.
    /// Demonstrates accessing a readonly variable.
    /// </summary>
    protected void btn_Account_Info_Click(object sender, EventArgs e)
    {
        try
        {
            // Read input values from textboxes
            string name = txt_AName.Text;
            int acNumber = Convert.ToInt32(txt_ANumber.Text);

            // Create account object using constructor
            Account ac = new Account(name, acNumber);

            // Display account holder name and account number
            lbl_Account_Info.Text = ac.acountHolderName + " " + ac.accountNumber;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Redirects user to the GST calculation page.
    /// </summary>
    protected void btn_GST_Page_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Taxpay.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}