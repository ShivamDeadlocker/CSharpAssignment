using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenericLib;


/// <summary>
/// This web uses a generic class and generic methods 
/// The generic method is display any product added in the library
/// </summary>
public partial class GenericLibrary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Displaying the Book Name and BooK Id

    protected void btn_Display_Click(object sender, EventArgs e)
    {
        try
        {
            Library<int> bookId = new Library<int>();
            bookId.AddItem(101);
            bookId.DisplayItem();

            Library<string> bookName = new Library<string>();
            bookName.AddItem("C# by MS");
            bookName.DisplayItem();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}

