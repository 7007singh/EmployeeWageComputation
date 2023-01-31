using System;

namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        /*public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int EMP_RATE_PER_HR = 20;*/
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");

            ComputeEmpWage("TCS",25,50,30);
            ComputeEmpWage("Google", 24, 70, 20);
            ComputeEmpWage("Mirosoft", 23, 40, 40);
            Console.ReadLine();
        }
        
        public static void ComputeEmpWage(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHrs)
        {
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            Random random = new Random();
            while (day <= maxWorkingDay && totalHrs <= maxWorkingHrs)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        //Console.WriteLine("\nFull Time Employee is Present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("\nPart Time Employee is Present");
                        empWage = 4;
                        break;
                    default:
                        //Console.WriteLine("\nEmployee is Absent");
                        break;
                }
                empWage = empHrs * empRatePerHrs;
                //Console.WriteLine("Day {0} Employee Wage:{1}", day, empWage);
                totalWage += empWage;
                day++;
                totalHrs += empWage;
            }
            Console.WriteLine("\nTotal Employee Wage for {3} for {0} days:{1} \nTotal working hours:{2}", (day - 1), totalWage, totalHrs, company);
        }
    }
}
