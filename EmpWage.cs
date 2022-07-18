using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWage
    {
        //This Program is used to calculate employee wage
        //Constant
        public const int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR;
        //Constructor
        public EmpWage(int ERPH)
        {
            EMP_RATE_PER_HOUR = ERPH;
        }
        public void EmpCheck()
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            //Computation
            int empChk = random.Next(2);
            if (empChk == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : " + empWage);
        }
    }
}
