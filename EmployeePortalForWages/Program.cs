using System;

namespace EmployeePortalForWages
{

    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        public static Double calculateDailyWage(Double fullDayHrs,Double wagePerHour)
        {
            return fullDayHrs * wagePerHour;
        }
        static void Main(string[] args)
        {

            int fullDayHrs = 10;
            int wagePerHour = 20;

            Random random = new Random();
            int empType = random.Next(0, 2);

            switch (empType) {
                case PART_TIME :
                    fullDayHrs = 8;
                    wagePerHour = 15;
                    Console.WriteLine("Part Time Employee Details ");
                    break;
                default:
                    Console.WriteLine("Full Time Employee Details ");
                    break;
            }


            Console.WriteLine("Daily Wage : " + calculateDailyWage(fullDayHrs, wagePerHour));
        }
    }
}
