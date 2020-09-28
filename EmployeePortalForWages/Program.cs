using System;

namespace EmployeePortalForWages
{

    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 0;

        public static Double calculateDailyWage(Double workingHrs,Double wagePerHour)
        {
            return workingHrs * wagePerHour;
        }

        public static Double calculateMonthlyWage(Double workingHrs,Double wagePerHour,Double workingDaysPerMonth)
        {
            return workingHrs * wagePerHour * workingDaysPerMonth;
        }

        static void Main(string[] args)
        {

            int workingHrs = 10;
            int wagePerHour = 20;
            int workingDaysPerMonth = 20;

            Random random = new Random();
            int empType = random.Next(0, 2);

            switch (empType) {
                case PART_TIME :
                    workingHrs = 8;
                    wagePerHour = 15;
                    workingDaysPerMonth = 10;
                    Console.WriteLine("Part Time Employee Details ");
                    break;
                default:
                    Console.WriteLine("Full Time Employee Details ");
                    break;
            }
            Console.WriteLine("Monthly Wage : " + calculateMonthlyWage(workingHrs, wagePerHour,workingDaysPerMonth));
        }
    }
}
