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
        public const int IS_PART_TIME = 2;
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
            int empChk = random.Next(3);
            switch (empChk)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is : " + empWage);
        }
    }
}
