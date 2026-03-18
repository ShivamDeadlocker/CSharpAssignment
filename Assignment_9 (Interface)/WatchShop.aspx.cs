using System;
using System.Web.UI;
using SWS;

/// <summary>
/// Web page for demonstrating SmartWatch features
/// like Fitness Tracking, Bluetooth connection,
/// and Notification service.
/// </summary>
public partial class WatchShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Displays fitness tracking information
    /// </summary>
    protected void btn_Fitness_Click(object sender, EventArgs e)
    {
        try
        {
            // Creating SmartWatch object
            SmartWatch ft = new SmartWatch();

            // Calling fitness tracking method
            lbl_Fitness.Text = ft.TrackFitness();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Displays Bluetooth connection status
    /// </summary>
    protected void btn_Bluetooth_Click(object sender, EventArgs e)
    {
        try
        {
            SmartWatch bl = new SmartWatch();

            // Calling Bluetooth functionality
            lbl_Bluetooth.Text = bl.ConnectBluetooth();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Displays smartwatch notifications
    /// </summary>
    protected void btn_Notification_Click(object sender, EventArgs e)
    {
        try
        {
            SmartWatch nt = new SmartWatch();

            // Calling notification service
            lbl_Notification.Text = nt.ShowNotification();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}