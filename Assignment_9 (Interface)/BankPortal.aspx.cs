using System;
using System.Web.UI;
using BankSystem;

/// <summary>
/// Web page that demonstrates bank operations
/// using interface-based account types.
/// </summary>
public partial class BankPortal : System.Web.UI.Page
{
    // Interface reference used for polymorphism
    IBank bank;

    /// <summary>
    /// Creates and returns Saving Account service
    /// with withdrawal amount from UI.
    /// </summary>
    public BankProcessService SAccount()
    {
        bank = new SavingAccount();

        // Creating service for saving account
        BankProcessService sap = new BankProcessService(1000, bank);

        // Reading withdrawal amount from textbox
        sap.WAmount = txt_SAWAmount.Text.Trim() == ""
                        ? 0
                        : Convert.ToDouble(txt_SAWAmount.Text);

        return sap;
    }

    /// <summary>
    /// Creates and returns Current Account service
    /// with withdrawal amount from UI.
    /// </summary>
    public BankProcessService CAccount()
    {
        bank = new CurrentAccount();

        // Creating service for current account
        BankProcessService cap = new BankProcessService(2000, bank);

        cap.WAmount = txt_CAWAmount.Text.Trim() == ""
                        ? 0
                        : Convert.ToDouble(txt_CAWAmount.Text);

        return cap;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Deposit money in Saving Account
    /// </summary>
    protected void btn_SADeposit_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService sap = SAccount();
            lbl_Deposit.Text = sap.Deposit();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Check Saving Account balance
    /// </summary>
    protected void btn_SABalance_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService sap = SAccount();
            lbl_Balance.Text = sap.CheckBalance();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Withdraw money from Saving Account
    /// </summary>
    protected void btn_SAWithDraw_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService sap = SAccount();
            lbl_WithDraw.Text = sap.Withdraw();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Deposit money in Current Account
    /// </summary>
    protected void btn_CADeposit_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService cap = CAccount();
            lbl_Deposit.Text = cap.Deposit();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Check Current Account balance
    /// </summary>
    protected void btn_CABalance_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService cap = CAccount();
            lbl_Balance.Text = cap.CheckBalance();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Withdraw money from Current Account
    /// </summary>
    protected void btn_CAWithDraw_Click(object sender, EventArgs e)
    {
        try
        {
            BankProcessService cap = CAccount();
            lbl_WithDraw.Text = cap.Withdraw();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

}