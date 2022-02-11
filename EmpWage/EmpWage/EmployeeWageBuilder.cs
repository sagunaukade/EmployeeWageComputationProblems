using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWageBuilder
    {

        //Initializing Constant
        private const int FULL_TIME_EMP = 1;
        private const int PART_TIME_EMP = 2;

        //Initializing Variables
        private int numOfCompany = 0;
        private List<CompanyEmployeeWage> companyEmpWageList;

        public EmployeeWageBuilder()
        {
            companyEmpWageList = new List<CompanyEmployeeWage>();
        }

        //Ability to manage employee wage of multiple companies using list
        public void AddCompanyEmpWageToList(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            CompanyEmployeeWage companyEmpWage = new CompanyEmployeeWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
            companyEmpWageList.Add(companyEmpWage);
        }

        public void IterateEmpWageCompany()
        {
            foreach (CompanyEmployeeWage companyEmp in companyEmpWageList)
            {
                companyEmp.SetTotalEmployWage(ComputeMonthlyWage(companyEmp));
                Console.WriteLine(companyEmp.CompanyTotalWageToString());
                Console.ReadLine();
            }
        }

        //Compute Employ Wage for Multiple Companies Using Procedural Ways 
        public int ComputeMonthlyWage(CompanyEmployeeWage companyEmp)
        {
            // local Variable
            int day = 0, hours = 0, dailyEmpHrs, dailyEmpWage, totalWage = 0;

            //Calculating Wages Per Month And Added Total Hours Condition
            Random randCheck = new Random();
            while (day < companyEmp.dayPerMonth && hours <= companyEmp.totalHours)
            {
                //Check Employ Is Present Or Absent          
                int checkAttend = randCheck.Next(0, 3);

                //Solved Using Switch Case
                switch (checkAttend)
                {
                    case FULL_TIME_EMP:
                        dailyEmpHrs = companyEmp.dailyHours;
                        break;
                    case PART_TIME_EMP:
                        dailyEmpHrs = companyEmp.dailyHours / 2;
                        break;
                    default:
                        dailyEmpHrs = 0;
                        break;
                }

                //Calculate Employ Daily Wage And Part Time Wage 
                dailyEmpWage = companyEmp.wagePerHours * dailyEmpHrs;
                day++;
                hours += dailyEmpHrs;
                totalWage += dailyEmpWage;
            }
            Console.WriteLine("Employ Name : {0} \nCompany Name : {1} \nTotal Wage Per Month Is : {2} \nTotal Working Hours : {3} \nTotal Working Day is : {4}", companyEmp.name, companyEmp.company, totalWage, hours, day);
            Console.ReadLine();
            return totalWage;
        }
    }
}
    

