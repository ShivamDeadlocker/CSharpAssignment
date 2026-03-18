using System;
using System.Web.UI;
using TollManagemen;

/// <summary>
/// Web page used to calculate toll amount for different vehicle types
/// like Car, Truck and Bus.
/// </summary>
public partial class TollPage : System.Web.UI.Page
{
    // Variables to store vehicle details
    string vnumber;
    string cname;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Reads vehicle number and owner name from input fields.
    /// </summary>
    public void readValue()
    {
        vnumber = txt_cnumber.Text;
        cname = txt_cname.Text;
    }

    /// <summary>
    /// Creates a Car object and calculates toll amount.
    /// </summary>
    protected void btn_Car_Click(object sender, EventArgs e)
    {
        try
        {
            // Read input values
            readValue();

            // Create car object
            Vehical car = new Car(vnumber, cname);

            // Calculate toll amount
            car.CalculateTollAmount(Vehical.BaseTollAmount);

            // Display result
            lbl_Car.Text =
                "Vehical Number: " + car.VehicleNumber +
                " Owner name: " + car.OwnerName +
                " Final Toll Amount: " + car.FinalTollAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Creates a Truck object and calculates toll amount.
    /// </summary>
    protected void btn_Truck_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            // Create truck object
            Vehical trk = new Truck(vnumber, cname);

            // Calculate toll amount
            trk.CalculateTollAmount(Vehical.BaseTollAmount);

            // Display result
            lbl_Truck.Text =
                "Vehical Number: " + trk.VehicleNumber +
                " Owner name: " + trk.OwnerName +
                " Final Toll Amount: " + trk.FinalTollAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    /// <summary>
    /// Creates a Bus object and calculates toll amount.
    /// </summary>
    protected void btn_Bus_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            // Create bus object
            Vehical bus = new Bus(vnumber, cname);

            // Calculate toll amount
            bus.CalculateTollAmount(Vehical.BaseTollAmount);

            // Display result
            lbl_Bus.Text =
                "Vehical Number: " + bus.VehicleNumber +
                " Owner name: " + bus.OwnerName +
                " Final Toll Amount: " + bus.FinalTollAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}