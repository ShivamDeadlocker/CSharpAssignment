using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenericReportGenerator;

/// <summary>
/// This web is showing the reports of diffrent class using the one generic method by taking a geneic list as a parameter
/// Reports includes the classes like Employee , Products and Order
/// </summary>
public partial class GenericReport : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Generate the Employee Class Report
    protected void btn_Employee_Click(object sender, EventArgs e)
    {
        try
        {
            List<Employee> EmployeeReport = new List<Employee>
            {
                new Employee() { Id = 101, Name = "Shivam" },
                new Employee() { Id = 102, Name = "sam" }
            };

            GenerateReport(EmployeeReport);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Generate the Product Class Report
    protected void btn_Product_Click(object sender, EventArgs e)
    {
        try
        {
            List<Product> ProductReports = new List<Product>()
            {
                new Product{ProductId=1001,ProductName="Mouse"},
                new Product{ProductId=1002,ProductName="KeyBoard"}
            };

            GenerateReport(ProductReports);

        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Generate the Order Class Report
    protected void btn_Order_Click(object sender, EventArgs e)
    {
        try
        {
            List<Order> OrdersReports = new List<Order>()
            {
                new Order{OrderId=5001,CustomerName="Amit"},
                new Order{OrderId=5002,CustomerName="Priya"}
            };

            GenerateReport(OrdersReports);

        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Generic Method for displaying the Reports of Different classes using the generic list 
    void GenerateReport<T>(List<T> items)
    {
        foreach (var i in items)
        {
            Response.Write(i.ToString() + "<br/>");
        }

    }
}