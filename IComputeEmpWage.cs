﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement_Day8
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth);
        public void computeEmpWage();
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int numOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp wage for Company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}