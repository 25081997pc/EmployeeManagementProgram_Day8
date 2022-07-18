using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public class EmpWage
    {
        //This Program is used to check whether employee is present or absent
        public void EmpCheck()
        {
            //Constant
            int IS_FULL_TIME = 1;

            Random random = new Random();
            //Computation
            int empChk = random.Next(2);
            if (empChk == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
