using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    /// <summary>
    /// The Class Consist of Functions related to Arithmetic Operations
    /// </summary>
    /// 
    public static class Calculator
    {
        public static string heading;
         
        static Calculator()
        {
             heading = "Inogic Calculator";
        }

        //This function is used for adding the two numbers
        public static int Add(int x, int y)
        {
            try
            {
                return x + y;

            }
            catch(Exception ex)
            {
                return 0;

            }
        }

        //This function is used for subtarcting the two numbers
        public static int Sub(int x, int y)
        {
            try
            {
                return x - y;

            }
            catch (Exception ex)
            {
                return 0;

            }
        }

        //This function is used for multiplying the two numbers
        public static int Mul(int x, int y)
        {
            try
            {
                return x * y;

            }
            catch (Exception ex)
            {
                return 0;

            }
        }

        //This function is used for dividing the two numbers
        public static int Div(int x, int y)
        {
            try
            {
                return x / y;

            }
            catch (Exception ex)
            {
                return 0;

            }
        }
    }
}
