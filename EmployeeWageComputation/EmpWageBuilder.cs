using System;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public string company;
        public int maxWorkingDay, maxWorkingHrs, empRatePerHrs;

        public EmpWageBuilder(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHrs) 
        {
            this.company = company;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHrs = empRatePerHrs;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            EmpWageBuilder tcs = new EmpWageBuilder("TCS", 25, 50, 30);
            tcs.ComputeEmpWage();
            EmpWageBuilder google = new EmpWageBuilder("Google", 24, 70, 20);
            google.ComputeEmpWage();
            EmpWageBuilder microsoft = new EmpWageBuilder("Mirosoft", 23, 40, 40);
            microsoft.ComputeEmpWage();
            Console.ReadLine();
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            Random random = new Random();
            while (day <= maxWorkingDay && totalHrs <= maxWorkingHrs)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empWage = 4;
                        break;
                    default:
                        break;
                }
                empWage = empHrs * empRatePerHrs;
                totalWage += empWage;
                day++;
                totalHrs += empWage;
            }
            Console.WriteLine("\nTotal Employee Wage for {3} for {0} days:{1} \nTotal working hours:{2}", (day - 1), totalWage, totalHrs, company);
        }
    }
}
