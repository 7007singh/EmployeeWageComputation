using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int MAX_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0;

            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC5 - CalculateWageForAMonth
            Random random = new Random();
            for(day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        Console.WriteLine("Full Time Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Paart Time Employee is Present");
                        empWage = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day {0} Employee Wage:{1}", day, empWage);
                totalWage += empWage;
            }
            Console.WriteLine("Total Employee Wage for {0} days:{1}", (day-1), totalWage);
            Console.ReadLine();
        }
    }
}
