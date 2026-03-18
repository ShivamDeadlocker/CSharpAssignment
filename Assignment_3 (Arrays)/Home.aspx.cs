using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    // Global Array declaration 
    int[] arr = new int[7] { 1, 3, 5, 2, 9, 1, 9 };

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string input = "";

            for (int i = 0; i < arr.Length; i++)
            {
                input = input + arr[i] + " ";
            }

            lbl_InputArray.Text = input;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }


    }

    #region Q1 to Q5
    //The Following Event Handler is Triggerd after the Reversed Button Click. The Static array will be reversed.
    protected void btn_Reverse_Click(object sender, EventArgs e)
    {
        try
        {

            string result = "";


            for (int j = arr.Length - 1; j >= 0; j--)
            {
                result = result + arr[j] + " ";
            }

            lbl_Reversed_Array.Text = result;

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The Following function gives the sum of all array elements
    protected void btn_Sum_Click(object sender, EventArgs e)
    {
        try
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            lbl_SumofArrayElementOutput.Text = sum.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following function is used for copying the one array element into another array
    protected void btn_Copy_Click(object sender, EventArgs e)
    {
        try
        {
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }

            string input = "";

            for (int i = 0; i < arr2.Length; i++)
            {
                input = input + arr[i] + " ";
            }

            lbl_NewArrayElementOutput.Text = input;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following function will return count of duplicate element in array 
    protected void btn_Duplicate_Click(object sender, EventArgs e)
    {
        try
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;

                    }

                }
            }

            lbl_CountDuplicateArrayElementOutput.Text = count.ToString();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }



    }

    //The following function is used to merging two array of same size and displaying in the descending order
    protected void btn_Merged_Click(object sender, EventArgs e)
    {
        try
        {
            int size = arr.Length;

            int[] mergedArray = new int[size * 2];

            int[] arr2 = { 11, 31, 15, 17, 19, 13, 91 };

            //Copy 1st array element using global array into new declare array
            for (int i = 0; i < size; i++)
            {
                mergedArray[i] = arr[i];
            }

            //Copy 2nd array uisng local array
            for (int j = 0; j < size; j++)
            {
                mergedArray[size + j] = arr2[j];
            }

            Array.Sort(mergedArray);

            string outPut = "";

            //Loop for printing the final merged array
            for (int k = 0; k < mergedArray.Length; k++)
            {
                outPut += mergedArray[k] + " ";
            }

            lbl_Merged_Array_Output.Text = outPut;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
    #endregion

    #region Q6 to Q10
    //The following function is used to count the frequency of each element of a array
    protected void btn_CountFrequency_Click(object sender, EventArgs e)
    {
        try
        {
            bool[] arrayVisited = new bool[arr.Length];

            string outPutText = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arrayVisited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arrayVisited[j] = true;
                    }
                }

                outPutText += "<br/>" + arr[i] + " = " + count + " times" + "<br/>";
            }

            lbl_Frequency_Output.Text = outPutText;

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following fnction is used to find Min and Max value of the array  
    protected void btn_FindMaxMin_Click(object sender, EventArgs e)
    {
        try
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            lbl_Max_Output.Text = max.ToString();

            lbl_Min_Output.Text = min.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following function is used to create the even and odd from the refrence array
    protected void btn_EvenOdd_Click(object sender, EventArgs e)
    {
        try
        {
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] evenArray = new int[evenCount];
            int[] oddArray = new int[oddCount];

            int evenArrayIndex = 0;
            int oddArrayIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArray[evenArrayIndex] = arr[i];
                    evenArrayIndex++;
                }
                else
                {
                    oddArray[oddArrayIndex] = arr[i];
                    oddArrayIndex++;
                }
            }

            string evenResult = "";
            string oddResult = "";


            for (int i = 0; i < evenArray.Length; i++)
            {
                evenResult += evenArray[i] + " ";
            }

            lbl_EvenArray_Output.Text = evenResult;

            for (int j = 0; j < oddArray.Length; j++)
            {
                oddResult += oddArray[j] + " ";
            }

            lbl_OddArray_Output.Text = oddResult;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following function is used to display the array in the Ascending order 
    protected void btn_Ascending_Click(object sender, EventArgs e)
    {
        try
        {
            int i, j, temp;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            string input = "";

            for (int k = 0; k < arr.Length; k++)
            {
                input = input + arr[k] + " ";
            }

            lbl_Elements_Ascending_Output.Text = input;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    //The following function is used to find the secomd smallest element from the array
    protected void btn_SecondSmallest_Click(object sender, EventArgs e)
    {
        try
        {

            int i, j, temp;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int smallest = arr[0];
            int secondSmallest = -1;

            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] != smallest)
                {
                    secondSmallest = arr[k];
                    break;
                }
            }

            lbl_SecondSmallest_Element_Output.Text = secondSmallest.ToString();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
    #endregion

}