using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// This web page is used for adding and searching the products details using Dictionary
/// </summary>
public partial class ProductInventory : System.Web.UI.Page
{
    //Globally Declare a Dictionary
    static Dictionary<int, string> Products = new Dictionary<int, string>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Add the 5 product in the Dictionary
    protected void btn_AddProduct_Click(object sender, EventArgs e)
    {
        try
        {
            Products.Add(101, "Mouse");
            Products.Add(111, "Keyboard");
            Products.Add(100, "ROM");
            Products.Add(120, "Monitor");
            Products.Add(115, "CPU");

            Response.Write("Products Added Sucessfully !!!");

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Find the product based on the key (product id) user input
    protected void btn_FindProduct_Click(object sender, EventArgs e)
    {
        try
        {
            int pid = Convert.ToInt32(txt_Id.Text);

            if (Products.ContainsKey(pid))
            {
                Response.Write("Product Info: " + Products[pid]);
            }
            else
            {
                Response.Write("Opps !!! Your Product is Not Find !!!!");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Function for displaying the Dictionary all elements
    public void Display()
    {
        foreach (var item in Products)
        {
            Response.Write("Id: " + item.Key + " " + "Products: " + item.Value + "<br />");
        }
    }

    //Display the Dictionary all elements
    protected void btn_DisplayProduct_Click(object sender, EventArgs e)
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
}