using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductOrder;

/// <summary>
/// Web page used to create an order object and apply discount
/// based on the order amount.
/// </summary>
public partial class PlaceaOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates an Discount object, applies discount and displays the result.
    /// </summary>
    protected void btn_AssignDiscount_Click(object sender, EventArgs e)
    {
        try
        {
            // Create Discount object with sample values
            Discount d = new Discount
            {
                OrderId = 61,
                Amount = 10000,
                IsDiscountApplied = false
            };

            // Call method to apply discount
            d.AssignGrade(d);

            // Display updated order information
            lbl_Product.Text =
                "Order Id: " + d.OrderId +
                "<br/>Amount: " + d.Amount +
                "<br/>Discount Applied: " + d.IsDiscountApplied;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}