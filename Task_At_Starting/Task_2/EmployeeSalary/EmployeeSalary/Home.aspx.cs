using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SalaryCalculation;

namespace EmployeeSalary
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //This event handler trigger after clicking on calculate button which display 
        //empID, empName and calculate netSalary. 
        protected void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_EmpId.Visible = true;
                lbl_EmpName.Visible = true;
                lab_result.Visible = true;
                lbl_Company.Visible = true;

                SalaryCalculation.Employee emp = new SalaryCalculation.Employee();
                emp.salary = Convert.ToInt32(txt_BasicSalary.Text);
                emp.hrAmount = Convert.ToInt32(txt_HRA.Text);
                emp.pfAmount = Convert.ToInt32(txt_PF.Text);
                emp.daAmount = Convert.ToInt32(txt_DA.Text);

                lbl_Company.Text = emp.company;
                lbl_EmpId.Text = txt_EmpId.Text;
                lbl_EmpName.Text = txt_EmpName.Text;
                lab_result.Text = (emp.calulateNetSalary()).ToString();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
        }
    }
}