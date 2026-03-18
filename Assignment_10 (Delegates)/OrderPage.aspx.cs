using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderProcessingSystem;

/// <summary>
/// This web page is demonstaring the multicast delegate example in on button click  following event happens 
/// Generate invoice, Send email confirmation, Update inventory and  Log order activity
/// </summary>
public partial class OrderPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_POrder_Click(object sender, EventArgs e)
    {
        try
        {
            ProcessingModules pm = new ProcessingModules();
            CommonProcessingService cps = new CommonProcessingService();
            PaymentProcessingModule ppm;

            ppm = new PaymentProcessingModule(pm.Generateinvoice);
            ppm += new PaymentProcessingModule(pm.EmailConfirmation);
            ppm += new PaymentProcessingModule(pm.UpdateInventory);
            ppm += new PaymentProcessingModule(pm.Loggs);

            lbl_Order_Output.Text = cps.OrderProcessingService(ppm);

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}