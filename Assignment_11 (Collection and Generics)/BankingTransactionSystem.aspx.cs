using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Banking Transaction System
/// This page demonstrates the use of Dictionary collection
/// where AccountNumber is the Key and CustomerName is the Value.
/// </summary>
public partial class BankingTransactionSystem : System.Web.UI.Page
{
    //Static Dictionary used to store account number and account holder name
    static Dictionary<int, string> AccountDetails = new Dictionary<int, string>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Adds some default account records and displays them
    /// </summary>
    protected void btn_Display_Click(object sender, EventArgs e)
    {
        try
        {
            AccountDetails.Add(101, "Shivam");
            AccountDetails.Add(102, "Sam");
            AccountDetails.Add(131, "Raj");
            AccountDetails.Add(161, "Ved");
            AccountDetails.Add(105, "Eja");

            Display();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Adds a new account into the dictionary after checking
    /// if the account number already exists.
    /// </summary>
    protected void btn_Add_Click(object sender, EventArgs e)
    {
        try
        {
            int key = Convert.ToInt32(txt_ANumber.Text);
            string val = txt_CName.Text;

            //Check if textbox is not empty and key does not exist
            if (txt_ANumber.Text != "" && !AccountDetails.ContainsKey(key))
            {
                AccountDetails.Add(key, val);

                Response.Write("Account Details Added!!!<br/>");

                Display();
            }
            else
            {
                Response.Write("Something went wrong, Please enter valid data!!!!<br/>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Displays all account records stored in the dictionary
    /// </summary>
    protected void btn_DisplayAll_Click(object sender, EventArgs e)
    {
        try
        {
            Display();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Searches an account using Account Number
    /// </summary>
    protected void btn_Search_Click(object sender, EventArgs e)
    {
        try
        {
            int snumber = Convert.ToInt32(txt_SNumber.Text);

            //Check whether the account exists in dictionary
            if (snumber.ToString() != "" && AccountDetails.ContainsKey(snumber))
            {
                Response.Write("Your Account Details: " + " Account Number: " + snumber + " Customer Name: "  + AccountDetails[snumber] + "<br/>");
            }
            else
            {
                Response.Write("Your Account Details Not Found !!!!<br/>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Method to display all account details stored in the dictionary
    /// </summary>
    public void Display()
    {
        foreach (var s in AccountDetails)
        {
            Response.Write("Account Number: " + s.Key +
                           " Customer Name: " + s.Value + "<br/>");
        }
    }
}