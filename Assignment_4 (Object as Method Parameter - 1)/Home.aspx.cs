using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRS;

/// <summary>
/// Web page used to display employee details,
/// update salary after promotion and navigate to student page.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Create employee object once and store in session
            if (!IsPostBack)
            {
                Session["emp"] = new Employee();
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Gets employee information and displays current salary.
    /// </summary>
    protected void btn_CurrentSal_Click(object sender, EventArgs e)
    {
        try
        {
            // Retrieve employee object from session
            Employee emp = (Employee)Session["emp"];

            // Assign values from textbox inputs
            emp.name = txt_Name.Text;
            emp.position = txt_Position.Text;
            emp.salary = Convert.ToDouble(txt_Salary.Text);

            // Display employee details
            lbl_SalaryInfo.Text = emp.name + "<br/>" + emp.position + "<br/>" + emp.salary + "<br/>";
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Updates employee salary after promotion (10% increment).
    /// </summary>
    protected void btn_UpdateSal_Click(object sender, EventArgs e)
    {
        try
        {
            // Get employee object from session
            Employee emp = (Employee)Session["emp"];

            // Call method to update salary
            emp.PromoteEmployee(emp);

            // Display updated employee details
            lbl_UpdatedSalary.Text = emp.name + "<br/>" + emp.position + "<br/>" + emp.salary + "<br/>";
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Redirects user to student information page.
    /// </summary>
    protected void btn_Student_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Information.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}