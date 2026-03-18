using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

public partial class UniqueDepartment : System.Web.UI.Page
{
    // List to store employee objects
    List<EmpSal> Emp = new List<EmpSal>();

    // Method to add predefined employee records into the list
    public void AddItem()
    {
        Emp.Add(new EmpSal() { Id = 101, Name = "Shivam", Salary = 50000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 3, Name = "Raj", Salary = 40000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 102, Name = "Ved", Salary = 60000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 104, Name = "Maju", Salary = 5000, Department = "Sales", DepartmentID = 201 });
        Emp.Add(new EmpSal() { Id = 105, Name = "Jhon", Salary = 10000, Department = "Sales", DepartmentID = 201 });
        Emp.Add(new EmpSal() { Id = 107, Name = "Ken", Salary = 100000, Department = "Sales", DepartmentID = 201 });
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Unique_Click(object sender, EventArgs e)
    {
        try
        {
            // Add employee data into the list
            AddItem();

            // LINQ query to get unique department names
            // ToLower() is used to avoid case sensitivity
            var result = (from empss in Emp select empss.Department.ToLower()).Distinct();

            // Loop through each unique department and display it
            foreach (var data in result)
            {
                Response.Write("unique department name: " + data + "<br />");
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}