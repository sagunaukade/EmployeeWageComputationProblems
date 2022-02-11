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
            EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
            empWageBuilder.AddCompanyEmpWageToList("Accenture", 20, 5, 10);
            empWageBuilder.AddCompanyEmpWageToList("Infosys", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWageToList("TCS", 35, 3, 25);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("\nTotal Emp Wage for Accenture: " + empWageBuilder.GetTotalWage("Accenture"));

            Console.ReadLine();
        }

    }
}