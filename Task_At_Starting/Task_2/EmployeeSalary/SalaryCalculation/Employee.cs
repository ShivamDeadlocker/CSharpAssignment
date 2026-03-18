using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    /// <summary>
    /// The Class is used for Displaying the Employee Details.
    /// The Class Consist the method for calculating the Net Salary.
    /// </summary>

    public class Employee
    {
        int sal;
        public int empID { get; set; }
        public string empName { get; set; }
        public int pfAmount { get; set; }
        public int daAmount { get; set; }
        public int hrAmount { get; set; }

        public string company;

        //Constructor For Setting the Company Name
        public Employee()
        {
            company = "Inogic Tech Pvt Ltd";
        }


        //Propertie For setting the value in Salary Vairable
        public int salary
        {
            get
            {
                return sal;
            }

            set
            {
                if (value > 0)
                {
                    sal = value;
                }
                else
                {
                    sal = 10000;
                }
            }
        }

        //Funtion for calculating net salary
        public int calulateNetSalary()
        {
            try
            {
                int NetSal = (sal + daAmount + hrAmount) - pfAmount;
                return NetSal;

            }
            catch (Exception ex)
            {
                return 0;
            }

        }

    }
}
