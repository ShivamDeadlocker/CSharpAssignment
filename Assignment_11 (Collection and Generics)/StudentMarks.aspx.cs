using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// This web page is used for showing the studnets records also showing the student with highest marks
/// </summary>
public partial class StudentMarks : System.Web.UI.Page
{
    //Global List Declaration
    static List<Student> StudentRecords = new List<Student>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_StudentMarks_Click(object sender, EventArgs e)
    {
        try
        {
            #region approach
            //Adding the student in the list
            AddStudent();

            foreach (var rec in StudentRecords)
            {
                Response.Write("Name: " + rec.Name + " " + "Marks: " + rec.Marks + "<br />");
            }

            //Called for getting student with highest marks 
            HighestMarks();
            #endregion
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    #region Function for adding student records in list using the object of Student Class
    public void AddStudent()
    {
        if (txt_Marks.Text.Trim() != "" && txt_Name.Text.Trim() != "")
        {
            Student s = new Student();

            s.Marks = Convert.ToInt32(txt_Marks.Text);
            s.Name = txt_Name.Text;

            StudentRecords.Add(s);
        }
        else {
            Response.Write("Please Enter a Valid Data!!!!");
        }

    }
    #endregion

    #region Function for finding the highest marks in the list 
    public void HighestMarks()
    {
        int hmarks = 0;
        string hname = "";

        foreach (var rec in StudentRecords)
        {
            if (rec.Marks > hmarks)
            {
                hmarks = rec.Marks;
                hname = rec.Name;
            }

        }

        Response.Write("Student with Highest Scores " + "Name: " + hname  + " " + "Marks: " + hmarks + "<br />");



    }
    #endregion


}

/// <summary>
/// Stroing the Marks and Name Properties
/// </summary>
public class Student
{
    public int Marks { get; set; }
    public string Name { get; set; }
}

