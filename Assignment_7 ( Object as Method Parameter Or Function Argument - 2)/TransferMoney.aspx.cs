using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transaction;

/// <summary>
/// Web page used to demonstrate fund transfer between two accounts.
/// Displays sender and receiver balances before and after transfer.
/// </summary>
public partial class TransferMoney : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates sender and receiver objects, transfers money
    /// and displays balances before and after transaction.
    /// </summary>
    protected void btn_Transfer_Click(object sender, EventArgs e)
    {
        try
        {
            // Create sender and receiver accounts
            SendReceive send = new SendReceive(101, "Shivam", 10000);
            SendReceive rece = new SendReceive(102, "Aditya", 20000);

            // Display balances before transfer
            lbl_Sender_Info.Text = send.EmpID + " " + send.EmpName + " " + send.Balance;
            lbl_Receiver_Info.Text = rece.EmpID + " " + rece.EmpName + " " + rece.Balance;

            // Transfer amount from sender to receiver
            SendReceive.TransferAmount(send, rece, Convert.ToDouble(txt_money.Text));

            // Display balances after transfer
            lbl_Sender_Info_AT.Text = send.EmpID + " " + send.EmpName + " " + send.Balance;
            lbl_Receiver_Info_AT.Text = rece.EmpID + " " + rece.EmpName + " " + rece.Balance;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}