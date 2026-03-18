using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMS;

/// <summary>
/// Web page used to calculate the consultant fees for different types of doctors
/// like GeneralPhysician , VisitingDoctor and Surgeon .
/// </summary>
public partial class DoctorFeesPortal : System.Web.UI.Page
{
    int did;
    string dname;
    double cfee;

    //Reading the input from the user
    public void readValue()
    {
        did = Convert.ToInt32(txt_DrId.Text);
        dname = txt_DrName.Text;
        cfee = Convert.ToDouble(txt_CFee.Text);
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Calculating the charges for GeneralPhysician
    protected void btn_GeneralPhysician_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Doctors dr = new GeneralPhysician(did,dname,cfee);
            dr.CalculateTotalFee(cfee);
            lbl_GeneralPhysician.Text = dr.DoctorId + " " + dr.DoctorName + " " + dr.ConsultationFee + " " + dr.TotalFee;

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
      

    }

    //Calculating the charges for Surgeon
    protected void btn_Surgeon_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Doctors sr = new Surgeon(did, dname, cfee);
            sr.CalculateTotalFee(cfee);
            lbl_Surgeon.Text = sr.DoctorId + " " + sr.DoctorName + " " + sr.ConsultationFee + " " + sr.TotalFee;

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Calculating the charges for VisitingDoctor
    protected void btn_VisitingDoctor_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Doctors vs = new VisitingDoctor(did, dname, cfee);
            vs.CalculateTotalFee(cfee);
            lbl_VisitingDoctor.Text = vs.DoctorId + " " + vs.DoctorName + " " + vs.ConsultationFee + " " + vs.TotalFee;

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}