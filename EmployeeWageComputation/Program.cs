using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1 - EmployeeAttendance
            Random random = new Random();
            int empAttendance = random.Next(0,2);
            if(empAttendance == isPresent)
            {
                Console.WriteLine("Emplouee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
