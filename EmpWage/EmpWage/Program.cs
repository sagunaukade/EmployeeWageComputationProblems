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
            EmployeeWageBuilder empwagebuilder = new EmployeeWageBuilder();
            empwagebuilder.AddCompanyEmpWageToList("Accenture", 20, 5, 10);
            empwagebuilder.AddCompanyEmpWageToList("Infosys", 10, 4, 20);
            empwagebuilder.AddCompanyEmpWageToList("TCS", 35, 3, 25);
            empwagebuilder.ComputeEmpWage();
            Console.ReadLine();
        }

    }
}
