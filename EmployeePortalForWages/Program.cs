using System;

namespace EmployeePortalForWages
{
    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        static void Main(string[] args)
        {

            Double empRatePerHour = 100;
            Double workingHrs = 10;
            Double numOfWorkingDays = 20;

            Random random = new Random();
            int empType = random.Next(0, 2);

            switch (empType) {
                case PART_TIME :
                    empRatePerHour = 80;
                    workingHrs = 8;
                    numOfWorkingDays = 15;
                    Console.WriteLine("Part Time Employee Details in following companies");
                    break;
                default:
                    Console.WriteLine("Full Time Employee Details in following companies");
                    break;
            }

            EmpWageBuilder capgemini = new EmpWageBuilder();
            capgemini.addCompanyWage("capgemini", empRatePerHour, numOfWorkingDays, workingHrs);
            Console.WriteLine(" Total wage in capgemini: " + capgemini.getTotalWage("capgemini"));

            EmpWageBuilder xyz = new EmpWageBuilder(); 
            capgemini.addCompanyWage("xyz", 10, 20, 12);
            Console.WriteLine(" Total wage in xyz: " + capgemini.getTotalWage("xyz"));
        }
    }
}
