using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Student;

/// <summary>
/// Web page used to create and display student information.
/// </summary>
public partial class Information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates a student object using entered details and displays the information.
    /// </summary>
    protected void btn_Student_Click(object sender, EventArgs e)
    {
        try
        {
            // Create student object using static method
            Student.Student s = Student.Student.CreateStudent(
                txt_Sname.Text,
                Convert.ToInt32(txt_Sroll.Text),
                txt_Sgrade.Text
            );

            // Display student details
            lbl_StudentInfo.Text = s.name + "<br/>" + s.rollNumber + "<br/>" + s.grade;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Redirects the user back to the home page.
    /// </summary>
    protected void btn_Home_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Home.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}