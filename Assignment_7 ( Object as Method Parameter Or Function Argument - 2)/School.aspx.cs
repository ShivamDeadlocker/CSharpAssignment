using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Student;

/// <summary>
/// Web page used to create a Marks object,
/// assign grade based on marks and display student details.
/// </summary>
public partial class School : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Creates a Marks object, assigns grade using AssignGrade method
    /// and displays the student information.
    /// </summary>
    protected void btn_AssignGrade_Click(object sender, EventArgs e)
    {
        try
        {
            // Create Marks object with sample data
            Marks m = new Marks
            {
                RollNo = 61,
                Name = "Shivam",
                TotalMarks = 80
            };

            // Call method to assign grade based on marks
            m.AssignGrade(m);

            // Display student information
            lbl_StudentInfo.Text =
                "Roll No: " + m.RollNo +
                "<br/>Name: " + m.Name +
                "<br/>Marks: " + m.TotalMarks +
                "<br/>Grade: " + m.Grade;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}