using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OTT;

/// <summary>
/// Web page used to calculate the amount for diffrent subscription plan
/// like Basic, Premium and Family.
/// </summary>
public partial class OverTheTop : System.Web.UI.Page
{
    string uname;
    int duration;

    //Reading the input from the user
    public void readValue()
    {
        uname = txt_UserName.Text;
        duration = Convert.ToInt32(txt_Duration.Text);
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Calculate the total price for Basic Plan
    protected void btn_BasicPlan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Subscription bsp = new BasicPlan(uname, duration);
            bsp.CalculateTotalPrice();
            lbl_BasicPlan.Text = bsp.UserName + " " + bsp.SubscriptionDuration + " " + bsp.TotalPrice;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Calculate the total price for Premium Plan
    protected void btn_PremiumPlan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Subscription prm = new PremiumPlan(uname, duration);
            prm.CalculateTotalPrice();
            lbl_PremiumPlan.Text = prm.UserName + " " + prm.SubscriptionDuration + " " + prm.TotalPrice;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Calculate the total price for Family Plan
    protected void btn_FamilyPlan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Subscription fp = new FamilyPlan(uname, duration);
            fp.CalculateTotalPrice();
            lbl_FamilyPlan.Text = fp.UserName + " " + fp.SubscriptionDuration + " " + fp.TotalPrice;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}