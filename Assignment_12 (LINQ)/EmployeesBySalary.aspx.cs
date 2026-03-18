using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeesSalary;

/// <summary>
/// This web page is use to display the highest salary among the employee using the LINQ query
/// Also Find the employee using there department
/// </summary>

public partial class EmployeesBySalary : System.Web.UI.Page
{
    //Created a Global List of EmpSal type and
    List<EmpSal> Emp = new List<EmpSal>();

    //Method for adding a predefind value in the List
    public void AddItem()
    {
        Emp.Add(new EmpSal() { Id = 101, Name = "Shivam", Salary = 50000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 103, Name = "Raj", Salary = 40000, Department = "IT" });
        Emp.Add(new EmpSal() { Id = 102, Name = "Ved", Salary = 60000, Department = "Sales" });
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Find the employee whose salary is greater than 50000 from the Emp list
    protected void btn_GetMax_Click(object sender, EventArgs e)
    {
        try
        {
            //Adding the List elements
            AddItem();

            Response.Write("List Elements" + "<br/>");

            //Looping Throught the List
            foreach (var em in Emp)
            {
                Response.Write(em.Id + " " + em.Name + " " +  em.Salary + " " + em.Department + "<br/>");
            }

            //Method 1
            var maxSal = from ems in Emp where ems.Salary > 50000 select ems;

            //Method 2
            // var maxSal = Emp.Where(s => s.Salary > 50000);

            Response.Write("List Elements in which the salary is greater than 50000" + "<br/>");

            //Looping through the list which have more than 50000 salary
            foreach (var emst in maxSal)
            {
                Response.Write(emst.Id + " " + emst.Name + " " + emst.Salary + "<br/>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Find the employee from the specific department
    protected void btn_Find_Click(object sender, EventArgs e)
    {
        try
        {
            //Adding the employee in the list 
            AddItem();

            //Getting the user input of the department
            string dept = txt_Dept.Text;

            if (Emp.Exists(s => s.Department.ToLower() == dept.ToLower()))
            {
                //uses a linq
                var emp = Emp.Where(d => d.Department == dept);

                Response.Write("Employee from  " + dept + " " + "Are Below List:" + "<br/>");

                foreach (var result in emp)
                {
                    Response.Write("Id: " + result.Id + " " + "Name: " + result.Name  + "<br/>");
                }
            }
            else
            {
                Response.Write("Employee not Found!!!!");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

}