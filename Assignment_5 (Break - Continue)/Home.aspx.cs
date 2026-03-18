using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    //Refrence bin
    int[] bin = new int[] { 4, 6, 1, 3, 7 };

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            lbl_binItems.Text = Load_Array(bin);
        }
    }

    //Method for loading the bin aaray
    public string Load_Array(int [] number)
    {
        try
        {
            string binElement = "";

            for (int i = 0; i < number.Length; i++)
            {
                binElement += number[i] + " ";
            }

            return binElement;
        }
        catch(Exception ex)
        {
            return ex.Message;
        }
    }

    //Event - handler for Find Button click
    protected void btn_Find_Click(object sender, EventArgs e)
    {
        try
        {
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == 3)
                {
                    Response.Write("Bin is under maintainance!!!");
                    continue;
                }

                if (bin[i] == 7)
                {
                    int position = i + 1;
                    lbl_output.Text = "Golden ticket found at position number: " + position.ToString();
                    break;
                }
                else
                {
                    lbl_output.Text = "Sorry, Golden ticket is not found in the bin!!!";
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}