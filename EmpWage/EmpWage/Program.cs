using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the employee wage computation programs");
            EmployeeWageBuilder company = new EmployeeWageBuilder();
            company.AddCompanyEmpWageToList("Accenture", "Saguna", 30, 7, 23, 220);
            company.AddCompanyEmpWageToList("Infosys", "Ganesh", 10, 20, 22, 103);
            company.AddCompanyEmpWageToList("TCS", "Raghav", 10, 17, 22, 170);
            company.AddCompanyEmpWageToList("Wipro", "Amruta", 35, 20, 20, 180);
            company.AddCompanyEmpWageToList("Cognizant", "Lavanya", 25, 90, 14, 210);
            company.IterateEmpWageCompany();
            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
