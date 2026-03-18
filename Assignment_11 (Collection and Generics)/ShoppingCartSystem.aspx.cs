using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Web Page is used to Display the basic Shopping Cart System Using the List Collections
/// </summary>
public partial class ShoppingCartSystem : System.Web.UI.Page
{
    static List<Shop> Product = new List<Shop>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //This button click add a Item in Cart
    protected void btn_Cart_Click(object sender, EventArgs e)
    {
        try
        {
            AddItem();
            Display();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This button click remove a Item from Cart
    protected void btn_Remove_Click(object sender, EventArgs e)
    {
        try
        {
            Remove();
            Display();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }


    }

    //This button click search a Item from the Cart
    protected void btn_Search_Click(object sender, EventArgs e)
    {
        try
        {
            Search();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }


    }

    /// <summary>
    /// Method to Add Item in Cart
    /// </summary>
    public void AddItem()
    {
        Shop s = new Shop() { Id = Convert.ToInt32(txt_PID.Text), Name = txt_PName.Text};
        Product.Add(s);
    }

    /// <summary>
    /// Method to Display Item of Cart
    /// </summary>
    public void Display()
    {
        foreach(var pro in Product)
        {
            Response.Write("ID: " + pro.Id + " Name: " + pro.Name + "<br/>");
        }
    }

    /// <summary>
    /// Method to Remove Item from Cart using Product ID
    /// </summary>
    public void Remove()
    {
        int id = Convert.ToInt32(txt_RID.Text);

        #region approch 1 
        //if(Product.Exists(p => p.Id == Convert.ToInt32(txt_RID.Text)))
        //{
        //    int i = Product.FindIndex(p => p.Id == Convert.ToInt32(txt_RID.Text));
        //    Product.RemoveAt(i);
        //    Response.Write("Item Removed Successfully<br>");

        //}
        //else
        //{
        //    Response.Write("Item Not Found<br>");

        //}
        #endregion

        #region aproach 2
        Shop item = Product.Find(p => p.Id == id);

        if (item != null)
        {
            Product.Remove(item);
            Response.Write("Item Removed Successfully<br>");
        }
        else
        {
            Response.Write("Item Not Found<br>");
        }
        #endregion
    }

    /// <summary>
    /// Method to Search Item in Cart
    /// </summary>
    public void Search()
    {
        int id = Convert.ToInt32(txt_SID.Text);

        Shop item = Product.Find(p => p.Id == id);

        if (item != null)
        {
            Response.Write("Item Found: " + item.Name + "<br>");
        }
        else
        {
            Response.Write("Item Not Found<br>");
        }
    }


}

/// <summary>
/// It Contains the Id and Name Properties
/// </summary>
public class Shop
{
    public int Id { get; set; }
    public string Name { get; set; }
}
