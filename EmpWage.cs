using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWage
    {
        //This Program is used to calculate employee Dailywage and total EmpWage for num of working days
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR;
        int NUM_OF_WORKING_DAYS;
        //Constructor
        public EmpWage(int ERPH, int NOWD)
        {
            EMP_RATE_PER_HOUR = ERPH;
            NUM_OF_WORKING_DAYS = NOWD;
        }
        public void EmpCheck()
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                Console.WriteLine("Day# : " + day + " Emp Daily Wage : " + empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
