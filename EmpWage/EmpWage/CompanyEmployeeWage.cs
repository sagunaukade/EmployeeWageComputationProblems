using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class CompanyEmployeeWage
    {
        //Declaring Variables
        public string company;
        public string name;
        public int wagePerHours;
        public int dailyHours;
        public int dayPerMonth;
        public int totalHours;
        public int totalEmpWage;

        public CompanyEmployeeWage(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.totalHours = totalHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        //Saving total wage for each company
        public void SetTotalEmployWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //Returning company name with total wage of the company
        public string CompanyTotalWageToString()
        {
            return "Company Name : " + this.company + " \nMonthly Wage Is Rs : " + this.totalEmpWage;
        }
    }
}
  

