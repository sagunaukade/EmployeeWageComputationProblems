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
            EmpAttendance.GetMonthlyEmpWage("Accenture", 20, 5, 10);
            EmpAttendance.GetMonthlyEmpWage("Infosys", 10, 4, 20);
            EmpAttendance.GetMonthlyEmpWage("TCS", 35, 3, 25);
            Console.ReadLine();
           
        }
    }
}
