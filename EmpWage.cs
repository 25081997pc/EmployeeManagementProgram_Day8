using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWage
    {
        //This Program is used to calculate employee total EmpWage for Maximum Hours 100 & max days 20
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR;
        int NUM_OF_WORKING_DAYS;
        int MAX_HOUR_IN_MONTH;
        //Constructor
        public EmpWage(int ERPH, int NOWD, int MHIM)
        {
            EMP_RATE_PER_HOUR = ERPH;
            NUM_OF_WORKING_DAYS = NOWD;
            MAX_HOUR_IN_MONTH = MHIM;
        }
        public void EmpCheck()
        {
            //Variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= MAX_HOUR_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs : " + empHrs);
                
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
