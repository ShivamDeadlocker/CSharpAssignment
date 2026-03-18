using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

public partial class HighestSalaries : System.Web.UI.Page
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

    protected void btn_top3_Click(object sender, EventArgs e)
    {
        try
        {
            #region Loops Iteration
            //Adding the List elements
            AddItem();

            Response.Write("List Elements" + "<br/>");

            //Looping Throught the List
            foreach (var em in Emp)
            {
                Response.Write(em.Id + " " + em.Name + " " + em.Salary + " " + em.Department + "<br/>");
            }
            #endregion

            #region LINQ
            //Method 1
            //var maxSal = from ems in Emp where ems.Salary > 50000 select ems;

            //Method 2
            var maxSal = Emp.OrderByDescending(s => s.Salary);

            //It will take top 3 element
            var maxCount = maxSal.Take(3);
            #endregion

            #region Operations
            Response.Write("List Elements in Descending Order" + "<br/>");

            //Looping through the sorted list which is in descending by salary
            foreach (var emst in maxSal)
            {
                Response.Write(emst.Id + " " + emst.Name + " " + emst.Salary + "<br/>");
            }

            Response.Write("List Elements top 3 element with highest salary" + "<br/>");

            //Looping through the sorted list which is in descending by salary and taking top 3 element
             foreach (var emst in maxCount)
            {
                Response.Write(emst.Id + " " + emst.Name + " " + emst.Salary + "<br/>");
            }
            #endregion

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}