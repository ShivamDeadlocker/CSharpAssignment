using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECommerceOrderManagement;

/// <summary>
/// This web page is used for displaying the Ecommerce Order Mana
/// </summary>
public partial class ECommerce : System.Web.UI.Page
{
    //Globally declare the Order Item List
    static List<Order> OrderItem = new List<Order>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //This button click add the order in the order list
    protected void btn_Cart_Click(object sender, EventArgs e)
    {
        try
        {
            AddItem();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This button click display the order list
    protected void btn_Display_Click(object sender, EventArgs e)
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

    //This button click remove the order from the order list
    protected void btn_Remove_Click(object sender, EventArgs e)
    {
        try
        {
            Remove();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //This button click search the order from the order list
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
    /// Method to Add Item in Order List
    /// </summary>
    public void AddItem()
    {
        if(txt_PID.Text != "" && txt_CName.Text != "" && txt_Amount.Text != "")
        {
            Order s = new Order { OrderId = Convert.ToInt32(txt_PID.Text), CustomerName = txt_CName.Text, Amount = Convert.ToDouble(txt_Amount.Text) };
            OrderItem.Add(s);
            Response.Write("Order Added!!!" + "<br/>");

        }
        else
        {
            Response.Write("Please Enter a Valid Order Details!!!" + "<br/>");

        }

    }

    /// <summary>
    /// Method to Display Items of Order List
    /// </summary>
    public void Display()
    {
        foreach (Order o in OrderItem)
        {
            Response.Write("Order Id: " + o.OrderId + " Customer Name: " + o.CustomerName + " Order Amount: " + o.Amount + "<br/>");
        }

    }

    /// <summary>
    /// Method to Remove Items of Order List
    /// </summary>
    public void Remove()
    {
        int ritemid = Convert.ToInt32(txt_RID.Text);
        if (ritemid.ToString() != "" && OrderItem.Exists(o => o.OrderId == ritemid))
        {
            Order o = OrderItem.Find(item => item.OrderId == ritemid);
            OrderItem.Remove(o);
            Response.Write("Order Removed!!!" + "<br/>");
        }
        else
        {
            Response.Write("Item Not Found!!!" + "<br/>");
        }
    }

    /// <summary>
    /// Method to Search Items of Order List
    /// </summary>
    public void Search()
    {
        int sitemid = Convert.ToInt32(txt_SID.Text);
        if (sitemid.ToString() != "" && OrderItem.Exists(o => o.OrderId == sitemid))
        {
            int index = OrderItem.FindIndex(item => item.OrderId == sitemid);
            Response.Write("Your Order Find At: " + index + "<br/>");

            Order o = OrderItem.Find(item => item.OrderId == sitemid);


            Response.Write("Your Order Details: " + o.CustomerName + " " + o.Amount + "<br/>");
        }
        else
        {
            Response.Write("Item Not Found!!!" + "<br/>");
        }


    }


}