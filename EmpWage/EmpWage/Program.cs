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
            EmployeeWageBuilderArray empwagebuilder = new EmployeeWageBuilderArray();
            empwagebuilder.AddCompanyEmpWage("Accenture", 20, 5, 10);
            empwagebuilder.AddCompanyEmpWage("Infosys", 10, 4, 20);
            empwagebuilder.AddCompanyEmpWage("TCS", 35, 3, 25);
            empwagebuilder.ComputeEmpWage();
            Console.ReadLine();
        }

    }
}
