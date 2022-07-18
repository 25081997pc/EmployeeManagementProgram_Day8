using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int MAX_HRS_IN_MONTH;
        int NUM_OF_WORKING_DAYS;
        int EMP_RATE_PER_HOUR;
        public EmpWage(int ERPR, int NOWD, int MHIM)
        {
            EMP_RATE_PER_HOUR = ERPR;
            NUM_OF_WORKING_DAYS = NOWD;
            MAX_HRS_IN_MONTH = MHIM;
        }
        public void computeEmployeeWage()
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            //Computation
            while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalEmpHrs <= MAX_HRS_IN_MONTH)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Day# :" + totalWorkingDays + " Emp Hrs :" + empHrs + " EmpWage : " + empWage);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }   
}
