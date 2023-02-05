using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CompanyDetails
    {
        public string company;
        public int maxWorkingDay, maxWorkingHrs, empRatePerHrs, totalWage;

        public CompanyDetails(string company, int maxWorkingDay, int maxWorkingHrs, int empRatePerHrs)
        {
            this.company = company;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRatePerHrs = empRatePerHrs;
        }

        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public override string ToString()
        {
            return $"Company:{company} totalwage:{totalWage}";
        }
    }
}
