using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LPS;

/// <summary>
/// Web page used to calculate the loan amount for different types of loans
/// like Home, Personal and Car Loan.
/// </summary>
public partial class LoanPortal : System.Web.UI.Page
{
    int lid;
    string cname;
    double lamount;

    //Reading the input from the user
    public void readValue()
    {
        lid = Convert.ToInt32(txt_LId.Text);
        cname = txt_CName.Text;
        lamount = Convert.ToDouble(txt_LAmount.Text);

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Calculation of Home Loan
    protected void btn_HomeLoan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Loan hl = new HomeLoan(lid,cname, lamount);
            hl.CalculateInterest();
            lbl_HomeLoan.Text = hl.LoanId + " " + hl.CustomerName+ " " + hl.InterestRate + " " + hl.LoanAmount + " " + hl.TotalAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //Calculation of Car Loan
    protected void btn_CarLoan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Loan cl = new CarLoan(lid, cname, lamount);
            cl.CalculateInterest();
            lbl_CarLone.Text = cl.LoanId + " " + cl.CustomerName + " " + cl.InterestRate + " " + cl.LoanAmount + " " + cl.TotalAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //Calculation of Personal Loan
    protected void btn_PersonalLoan_Click(object sender, EventArgs e)
    {
        try
        {
            readValue();

            Loan pl = new PersonalLoan(lid, cname, lamount);
            pl.CalculateInterest();
            lbl_PersonalLoan.Text = pl.LoanId + " " + pl.CustomerName + " " + pl.InterestRate + " " + pl.LoanAmount + " " + pl.TotalAmount;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}