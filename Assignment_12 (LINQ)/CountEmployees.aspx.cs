using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

public partial class CountEmployees : System.Web.UI.Page
{
    //Created a Global List of EmpSal type and
    List<EmpSal> Emp = new List<EmpSal>();

    //Method for adding a predefind value in the List
    public void AddItem()
    {
        Emp.Add(new EmpSal() { Id = 101, Name = "Shivam", Salary = 50000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 103, Name = "Raj", Salary = 40000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 102, Name = "Ved", Salary = 60000, Department = "Sales" });
        Emp.Add(new EmpSal() { Id = 104, Name = "Maju", Salary = 5000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 105, Name = "Jhon", Salary = 10000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 107, Name = "Ken", Salary = 100000, Department = "Sales" });
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Display the count of employee with department
    protected void btn_Group_Click(object sender, EventArgs e)
    {
        try
        {
            // Add employees to the list
            AddItem();

            // Group employees based on Department using LINQ
            var depGrp = Emp.GroupBy(s => s.Department);

            // Loop through each department group
            foreach (var emst in depGrp)
            {
                // Display department name and number of employees in that department
                Response.Write("Department: " + emst.Key + " Employee Count: " + emst.Count() + "<br/>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}