using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

public partial class JoinTwoCollections : System.Web.UI.Page
{
    // List to store employee data
    List<EmpSal> Emp = new List<EmpSal>();

    // List to store department data
    List<DepartmentNew> Dpt = new List<DepartmentNew>();

    // Method to add predefined employee records into the list
    public void AddItem()
    {
        Emp.Add(new EmpSal() { Id = 101, Name = "Shivam", Salary = 50000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 3, Name = "Raj", Salary = 40000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 102, Name = "Ved", Salary = 60000, Department = "II", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 104, Name = "Maju", Salary = 5000, Department = "Sales", DepartmentID = 201 });
        Emp.Add(new EmpSal() { Id = 105, Name = "Jhon", Salary = 10000, Department = "Sales", DepartmentID = 201 });
        Emp.Add(new EmpSal() { Id = 107, Name = "Ken", Salary = 100000, Department = "Sales", DepartmentID = 201 });
    }

    // Method to add predefined department records into the list
    public void AddDpt()
    {
        Dpt.Add(new DepartmentNew() { DeptId = 200, Dname = "IT" });
        //Dpt.Add(new DepartmentNew() { DeptId = 201, Dname = "Sales" });
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Join_Click(object sender, EventArgs e)
    {
        try
        {
            // Add employee data
            AddItem();

            // Add department data
            AddDpt();

            // LINQ Join operation to combine employee and department collections
            // Matching is done using DepartmentID and DeptId
            var result = from empssss in Emp
                         join dpt in Dpt
                         on empssss.DepartmentID equals dpt.DeptId
                         select new
                         {
                             empname = empssss.Name,
                             dptname = dpt.Dname
                         };

            // Display employee name with department name
            foreach (var data in result)
            {
                Response.Write("Emp Name: " + data.empname + " Department Name: " + data.dptname + "<br />");
            }
        }
        catch (Exception ex)
        {
            // Display error message if exception occurs
            Response.Write(ex.Message);
        }

    }
}