using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
            ComputeEmpWage();
            Console.ReadLine();
        }
        
        public static void ComputeEmpWage()
        {
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC5 - CalculateWageForAMonth
            Random random = new Random();
            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_HRS)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        Console.WriteLine("\nFull Time Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("\nPart Time Employee is Present");
                        empWage = 4;
                        break;
                    default:
                        Console.WriteLine("\nEmployee is Absent");
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Day {0} Employee Wage:{1}", day, empWage);
                totalWage += empWage;
                day++;
                totalHrs += empWage;
            }
            Console.WriteLine("Total Employee Wage for {0} days:{1} and total working hours {2}", (day - 1), totalWage, totalHrs);
        }
    }
}
