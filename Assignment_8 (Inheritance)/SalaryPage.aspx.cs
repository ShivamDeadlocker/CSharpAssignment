using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayrollSystem;

/// <summary>
/// Web page used to calculate the salary for different employee types
/// like Contract Based Employee Or Permanent Employee.
/// </summary>
public partial class SalaryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Calculating salary for Contract Based Employee
    protected void btn_Contract_Click(object sender, EventArgs e)
    {

        Employee con = new ContractEmployee(Convert.ToInt32(txt_EmpId.Text),txt_EmpName.Text, Convert.ToDouble(txt_BasicSal.Text));
        con.CalculateSalary(con.BasicSalary);

        lbl_Contract.Text = con.EmployeeId + " " + con.EmployeeName + " " + con.BasicSalary + " " + con.calculatedSalary; 
    }

    //Calculating salary for Permanent Employee
    protected void btn_Permenant_Click(object sender, EventArgs e)
    {
        Employee per = new PermanentEmployee(Convert.ToInt32(txt_EmpId.Text), txt_EmpName.Text, Convert.ToDouble(txt_BasicSal.Text));
        per.CalculateSalary(per.BasicSalary);

        lbl_Permenant.Text = per.EmployeeId + " " + per.EmployeeName + " " + per.BasicSalary + " " + per.calculatedSalary;
    }
}