using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeCount;

/// <summary>
/// Web page used to create employee objects and display
/// the total number of employees created.
/// </summary>
public partial class Count : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates a new employee object and updates the employee count.
    /// </summary>
    protected void btn_Add_Emp_Click(object sender, EventArgs e)
    {
        // Create new employee object
        Employee emp = new Employee();

        // Display total employee count using static property
        lbl_Emp_Count.Text = "Employee Count: " + Employee.EmpCount;
    }
}