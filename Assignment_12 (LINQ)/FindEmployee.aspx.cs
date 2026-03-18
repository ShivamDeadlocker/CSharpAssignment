using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

public partial class FindEmployee : System.Web.UI.Page
{
    //Created a Global List of EmpSal type and
    List<EmpSal> Emp = new List<EmpSal>();

    List<DepartmentNew> Dpt = new List<DepartmentNew>();

    //Method for adding a predefind value in the List
    public void AddItem()
    {
        Emp.Add(new EmpSal() { Id = 101, Name = "Shivam", Salary = 50000, Department = "IT", DepartmentID=200 });
        Emp.Add(new EmpSal() { Id = 3, Name = "Raj", Salary = 40000, Department = "IT", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 102, Name = "Ved", Salary = 60000, Department = "II", DepartmentID = 200 });
        Emp.Add(new EmpSal() { Id = 104, Name = "Maju", Salary = 5000, Department = "Sales", DepartmentID = 201});
        Emp.Add(new EmpSal() { Id = 105, Name = "Jhon", Salary = 10000, Department = "Sales", DepartmentID = 201 });
        Emp.Add(new EmpSal() { Id = 107, Name = "Ken", Salary = 100000, Department = "Sales", DepartmentID = 201 });
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Find the Employee 
    protected void btn_Find_Click(object sender, EventArgs e)
    {
        try
        {
            AddItem();

            int id = 3;

            //Method 1
            IEnumerable<EmpSal> result = from epms in Emp where epms.Id == id select epms;

            //Method 2
            //IEnumerable<EmpSal> result = Emp.Where(eid => eid.Id == id);

            foreach (EmpSal data in result)
            {
                Response.Write("Id: " + data.Id +  " Name: " + data.Name +  " Salary: " + data.Salary);
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}