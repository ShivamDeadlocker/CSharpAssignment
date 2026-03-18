using System;
using System.Web.UI;
using SmartVendingMaachine;

/// <summary>
/// Web UI page used to interact with the vending machine.
/// Handles loading products and processing purchase requests.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    // Vending machine object used for inventory and purchase operations
    VendingMachine vm;

    /// <summary>
    /// Page load event. Initializes vending machine and loads data.
    /// </summary>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Create vending machine object only once and store in session
            if (Session["vm"] == null)
            {
                Session["vm"] = new VendingMachine();
            }

            vm = (VendingMachine)Session["vm"];

            // Load data only first time when page loads
            if (!IsPostBack)
            {
                LoadInventory();
                LoadProducts();
            }
        }
        catch (Exception ex)
        {
            lbl_Result.Text = ex.Message;
        }
    }

    /// <summary>
    /// Loads current inventory into GridView.
    /// </summary>
    public void LoadInventory()
    {
        try
        {
            // Bind product list to grid
            grid_Products.DataSource = vm.Products;
            grid_Products.DataBind();
        }
        catch (Exception ex)
        {
            lbl_Result.Text = ex.Message;
        }
    }

    /// <summary>
    /// Loads available products into the dropdown list.
    /// </summary>
    public void LoadProducts()
    {
        try
        {
            // Bind product names to dropdown
            ddl_Product.DataSource = vm.Products;
            ddl_Product.DataValueField = "Name";
            ddl_Product.DataTextField = "Name";
            ddl_Product.DataBind();
        }
        catch (Exception ex)
        {
            lbl_Result.Text = ex.Message;
        }
    }

    /// <summary>
    /// Handles product purchase when Buy button is clicked.
    /// </summary>
    protected void btn_Buy_Click(object sender, EventArgs e)
    {
        try
        {
            // Get user inputs
            int index = ddl_Product.SelectedIndex;
            int quantity = Convert.ToInt32(txt_Quantity.Text);
            int money = Convert.ToInt32(txt_Money.Text);

            // Call vending machine purchase method
            string result = vm.BuyProduct(index, quantity, money);

            // Show purchase result
            lbl_Result.Text = result;

            // Refresh inventory after purchase
            LoadInventory();
        }
        catch (Exception ex)
        {
            lbl_Result.Text = ex.Message;
        }
    }
}