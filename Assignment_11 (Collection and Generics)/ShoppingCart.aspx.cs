using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// This web page is used for adding the product item in the List, Displaying and Removing
/// </summary>
public partial class ShoppingCart : System.Web.UI.Page
{
    //Global List Declare for Products
    static List<string> Product = new List<string>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //This button click will add the Product item in the list
    protected void btn_Add_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_Name.Text.Trim() != "")
            {
                Product.Add(txt_Name.Text);
                Response.Write("Product added!!!");
            }
            else {

                Response.Write(" Please Enter Valid Product Name!!!");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This button click will display the Product which are present in the list
    protected void btn_Display_Click(object sender, EventArgs e)
    {
        foreach (string i in Product)
        {
            Response.Write("Product Name: " +  i + "<br/>");
        }
    }

    //This button click will remove the Product item from the list
    protected void btn_Remove_Click(object sender, EventArgs e)
    {
        string item = txt_RName.Text;
        if (item != "" && Product.Contains(item))
        {
            Response.Write("Product found At: " + Product.IndexOf(item));
            Product.Remove(item);
            Response.Write("Product is Removed!!!");
        }
        else
        {
            Response.Write("Sorry!!! Product Is Not Found!!!");
        }
    }
}