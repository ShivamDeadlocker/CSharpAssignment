using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeWithList;

/// <summary>
/// This web page is using the Generic List for prinitting the Employee Data
/// </summary>
public partial class EmployeeRecords : System.Web.UI.Page
{
    static List<Employee> emp = new List<Employee>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Display_Click(object sender, EventArgs e)
    {
        try
        {
            //uasig Object Initializer
            Employee e1 = new Employee() { EmpId = 100, Name = "Shivam", Salary = 13000 };
            Employee e2 = new Employee() { EmpId = 120, Name = "Raj", Salary = 12000 };
            Employee e3 = new Employee() { EmpId = 110, Name = "Vad", Salary = 11000 };

            //Adding the element in the List by passing the Object of Employee 
            emp.Add(e1);
            emp.Add(e2);
            emp.Add(e2);

            //Printting the Element of List 
            foreach (var rec in emp)
            {
                Response.Write(rec);
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}