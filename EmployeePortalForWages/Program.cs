using System;

namespace EmployeePortalForWages
{
    class Program
    {
        public static Double calculateDailyWage(Double fullDayHrs,Double wagePerHour)
        {
            return fullDayHrs * wagePerHour;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Daily Wage : " + calculateDailyWage(8, 20));
        }
    }
}
