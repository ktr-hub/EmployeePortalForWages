using System;

namespace EmployeePortalForWages
{
    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        static void Main(string[] args)
        {
            EmpWageBuilder company = new EmpWageBuilder();
            company.addCompanyWage("capgemini", 15, 150, 9);
            company.addCompanyWage("xyz", 10, 200, 12);
            company.setWage();
        }
    }
}
