using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpSal;

/// <summary>
/// Web page used to enter employee details and calculate
/// HRA, Tax and Net Salary.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates employee object, calculates salary components
    /// and displays the result.
    /// </summary>
    protected void btn_NetSalary_Click(object sender, EventArgs e)
    {
        try
        {
            // Create employee object
            CalculateEmp emp = new CalculateEmp();

            // Assign values from input fields
            emp.EmpID = Convert.ToInt32(txt_EmpID.Text);
            emp.EmpName = txt_EmpName.Text;
            emp.BasicSalary = Convert.ToInt32(txt_EmpSalary.Text);

            // Call method that calculates HRA, Tax and Net Salary
            emp.CalculateSalary(emp);

            // Display calculated values
            lbl_Salary_Info.Text =
                "HRA: " + emp.HRA +
                "<br/>Tax: " + emp.Tax +
                "<br/>Net Salary: " + emp.NetSalary;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}