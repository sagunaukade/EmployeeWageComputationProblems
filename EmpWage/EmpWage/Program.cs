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
            EmpAttendance Accenture = new EmpAttendance("Accenture", 20, 5, 10);
            Accenture.GetMonthlyEmpWage();
            Console.WriteLine(Accenture.ToString());

            EmpAttendance microsoft = new EmpAttendance("Infosys", 10, 4, 20);
            microsoft.GetMonthlyEmpWage();
            Console.WriteLine(microsoft.ToString());

            EmpAttendance deloitte = new EmpAttendance("TCS", 35, 3, 25);
            deloitte.GetMonthlyEmpWage();
            Console.WriteLine(deloitte.ToString());

            Console.ReadLine();
        }

    }
}
