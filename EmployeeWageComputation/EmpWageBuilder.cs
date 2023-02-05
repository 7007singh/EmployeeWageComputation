using System;
using System.Collections.Generic;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        List<CompanyDetails> list;
        int numberOfCompany = 0;
        
        public EmpWageBuilder()
        {
            list = new List<CompanyDetails>();
        }

        public void AddCompanyDetail(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHrs)
        {
            CompanyDetails companyDetails = new CompanyDetails(company, maxWorkingDay, maxWorkingHrs, empRatePerHrs);
            list.Add(companyDetails);
        }

        public void IterateOverCompanies()
        {
            for (int i = 0; i < list.Count; i++)
            {
                int totalWage = ComputeEmpWage(list[i]);
                list[i].SetTotalWage(totalWage);
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            EmpWageBuilder builder = new EmpWageBuilder();
            builder.AddCompanyDetail("TCS", 25, 50, 30);
            builder.AddCompanyDetail("Google", 24, 70, 20);
            builder.AddCompanyDetail("Mirosoft", 23, 40, 40);
            builder.IterateOverCompanies();
            Console.ReadLine();
        }
        public int ComputeEmpWage(CompanyDetails details)
        {
            int empHrs = 0, empWage = 0, day = 1, totalWage = 0, totalHrs = 0;

            Random random = new Random();
            while (day <= details.maxWorkingDay && totalHrs <= details.maxWorkingHrs)
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
                empWage = empHrs * details.empRatePerHrs;
                totalWage += empWage;
                day++;
                totalHrs += empWage;
            }
            Console.WriteLine("\nTotal Employee Wage for {3} for {0} days:{1} \nTotal working hours:{2}", (day - 1), totalWage, totalHrs, details.company);
            return totalWage;
        }
    }
}
