using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecalci;

/// <summary>
/// Web page to calculate employee bonus using Lambda Expression.
/// </summary>
public partial class BonusPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Calculates bonus when button is clicked.
    /// </summary>
    protected void btn_Bonus_Click(object sender, EventArgs e)
    {
        try
        {
            PayrollSystem ps;
            EmployeCalci ec = new EmployeCalci();

            //Lambda expression for bonus rule
            ps = new PayrollSystem((salary) =>
            {
                if (salary > 50000)
                    return salary * 0.10; //10% bonus
                else
                    return salary * 0.05; //5% bonus
            });

            lbl_BonusSalary_Output.Text =
                "Your bonus is: " +
                ec.CalculateBonus(Convert.ToDouble(txt_Salary.Text), ps);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}