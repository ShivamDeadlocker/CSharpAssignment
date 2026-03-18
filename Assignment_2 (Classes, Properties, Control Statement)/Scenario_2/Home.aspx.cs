using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitTrack;

/// <summary>
/// UI page used to interact with FitTrack features such as age validation,
/// plank challenge, BMI calculation and workout suggestions.
/// </summary>
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Validates the entered age and calculates membership amount.
    /// </summary>
    protected void btn_Check_Click(object sender, EventArgs e)
    {
        try
        {
            lbl_Error.Text = "";

            // Create user object
            User u = new User();

            // Get age input from textbox
            int ageValue = Convert.ToInt32(txt_Age.Text);

            // Assign age which triggers validation inside property
            u.age = ageValue;

            // Show validation message
            lbl_Age.Text = u.alert;

            // Display membership amount
            lbl_Amount.Text = "Membership Amount: " + u.GetAmount();
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Displays plank challenge milestones (10, 20, 30 and 60 seconds).
    /// </summary>
    protected void btn_Plank_Click(object sender, EventArgs e)
    {
        try
        {
            User u = new User();

            // Call plank challenge method
            lbl_Plank.Text = u.PlankChallange();
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Calculates and displays BMI based on height and weight.
    /// </summary>
    protected void btn_Bmi_Click(object sender, EventArgs e)
    {
        try
        {
            // Read height and weight values
            double height = Convert.ToDouble(txt_height.Text);
            double weight = Convert.ToDouble(txt_weight.Text);

            // Call static BMI method
            lbl_bmi.Text = Convert.ToString(FitTrack.User.Bmi(height, weight));
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Simulates running laps and shows break message on lap 3.
    /// </summary>
    protected void btn_Run_Click(object sender, EventArgs e)
    {
        try
        {
            User u = new User();

            // Display lap messages
            lbl_run.Text = u.Running();
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Displays the username which is set during object creation.
    /// </summary>
    protected void btn_Name_Click(object sender, EventArgs e)
    {
        try
        {
            // Username cannot be changed after object creation
            SampleUser su = new SampleUser("ShivamP");

            lbl_name.Text = su.userName;
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Provides workout suggestion based on selected intensity.
    /// </summary>
    protected void btn_Suggestion_Click(object sender, EventArgs e)
    {
        try
        {
            SampleUser su = new SampleUser("ShivamP");

            // Get intensity value from dropdown
            int intensity = Convert.ToInt32(ddl_Intensity.SelectedValue);

            // Display workout suggestion
            lbl_Suggestion_Output.Text =
                su.userName + " suggestion for you: " + su.Workout(intensity);
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }

    /// <summary>
    /// Checks if the user qualifies for the Pro Medal reward.
    /// </summary>
    protected void btn_Prize_Click(object sender, EventArgs e)
    {
        try
        {
            SampleUser su = new SampleUser("ShivamP");

            // Read steps count and active days
            int steps = Convert.ToInt32(txt_steps_count.Text);
            int days = Convert.ToInt32(txt_active_day.Text);

            // Check reward eligibility
            lbl_Prize_Output.Text =
                su.userName + " Your " + su.Prize(steps, days);
        }
        catch (Exception ex)
        {
            lbl_Error.Text = ex.Message;
        }
    }
}