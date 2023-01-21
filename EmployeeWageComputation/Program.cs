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
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC2 - CalculateDailyWage
            Random random = new Random();
            int empAttendance = random.Next(0,2);
            if(empAttendance == FULL_TIME)
            {
                Console.WriteLine("Emplouee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                //empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage:{0}" + empWage);
            Console.ReadLine();
        }
    }
}
