using System;

namespace EmployeePortalForWages
{
    class Company
    {

        public void calculateWage(string companyName, Double workingHrsPerDay, Double maxWorkingHrs, Double maxWorkingDays)
        {
            Double workingHrs = 0;
            Double workingDays = 0;
            Double RATE_PER_HOUR = 100;
            while (workingHrs < maxWorkingDays && workingDays < maxWorkingDays)
            {
                workingHrs = workingHrs + workingHrsPerDay;
                workingDays++;
            }
            Console.WriteLine(" In " + companyName + " " + workingDays * workingHrsPerDay * RATE_PER_HOUR);
        }
    }
    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        static void Main(string[] args)
        {

            int maxWorkingHrs = 100;
            int workingHrsPerDay = 10;
            int maxWorkingDays = 20;

            Random random = new Random();
            int empType = random.Next(0, 2);

            switch (empType) {
                case PART_TIME :
                    maxWorkingHrs = 80;
                    workingHrsPerDay = 8;
                    maxWorkingDays = 15;
                    Console.WriteLine("Part Time Employee Details ");
                    break;
                default:
                    Console.WriteLine("Full Time Employee Details ");
                    break;
            }

            Company capgemini = new Company();
            capgemini.calculateWage("capgemini",workingHrsPerDay,maxWorkingHrs,maxWorkingDays);
        }
    }
}
