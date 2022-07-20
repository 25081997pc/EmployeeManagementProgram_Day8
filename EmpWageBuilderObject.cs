using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWageBuilderObject
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void computeEmpWage()
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while(totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empchk = random.Next(3);
                switch(empchk)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp wage for Company : " + this.company + " is : " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp wage for Company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
