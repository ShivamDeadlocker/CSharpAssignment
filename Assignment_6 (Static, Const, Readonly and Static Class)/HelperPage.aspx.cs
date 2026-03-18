using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Validation;

/// <summary>
/// Web page used to call helper class methods
/// for login, validation and conversion operations.
/// </summary>
public partial class HelperPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Calls methods from the utility (static) class and displays the results.
    /// </summary>
    protected void btn_Validate_Click(object sender, EventArgs e)
    {
        try
        {
            // Call static helper methods and display output
            lbl_Validate_Output.Text =
                ValidateLogin.Login()      + "<br/>" +
                ValidateLogin.Validation() + "<br/>" +
                ValidateLogin.Conversion();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}