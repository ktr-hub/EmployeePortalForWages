using System;

namespace EmployeePortalForWages
{

    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        public static Double calculateWage(Double workingHrsPerDay, Double maxWorkingHrs,Double maxWorkingDays)
        {
            Double workingHrs = 0;
            Double workingDays = 0;
            Double RATE_PER_HOUR = 100;
            while (workingHrs < maxWorkingDays && workingDays < maxWorkingDays)
            {
                workingHrs = workingHrs + workingHrsPerDay;
                workingDays++;
            }
            return workingDays * workingHrsPerDay * RATE_PER_HOUR;
        }

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

            Console.WriteLine("Total Wage till the condition reached : " + calculateWage(workingHrsPerDay,maxWorkingHrs,maxWorkingDays));
        }
    }
}
