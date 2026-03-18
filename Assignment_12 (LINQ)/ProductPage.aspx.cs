using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductStore;

/// <summary>
/// This web page is sorting product list by linq by using extension method as well as using query
/// </summary>
public partial class ProductPage : System.Web.UI.Page
{
    //Created a Global List of Product type and
    List<Product> Pro = new List<Product>();

    //Method for adding a predefind value in the List
    public void AddItem()
    {
        Pro.Add(new Product() { ProductId = 121, ProductName = "Mouse", Price = 500});
        Pro.Add(new Product() { ProductId = 146, ProductName = "Keyboard", Price = 400 });
        Pro.Add(new Product() { ProductId = 101, ProductName = "Monitor", Price = 2000 });
        Pro.Add(new Product() { ProductId = 100, ProductName = "CPU", Price = 5000 });
        Pro.Add(new Product() { ProductId = 110, ProductName = "RAM", Price = 4000 });
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Sorting the Products List by Price
    protected void btn_Sort_Click(object sender, EventArgs e)
    {
        try
        {
            //Adding the element in the list
            AddItem();

            Response.Write("Before Sorting" + "<br/>");

            //Looping to the unsorted sorted list and printing the elements
            foreach (var item in Pro)
            {
                Response.Write("Id: " + item.ProductId + " " + item.ProductName + " " + item.Price + " " + "<br/>");
            }


            Response.Write("After Sorting" + "<br/>");


            //Method 1
            //var sortedItemByQuery = from p in Pro orderby p.Price select p;

            //Method 2
            var sortedItemByMethod = Pro.OrderBy(s => s.Price);

            //Looping to the sorted list and printing the elements
            foreach (var item in sortedItemByMethod)
            {
                Response.Write("Id: " + item.ProductId + " " + item.ProductName + " " + item.Price + " " + "<br/>");
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}