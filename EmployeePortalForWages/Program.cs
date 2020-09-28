using System;

namespace EmployeePortalForWages
{
    class Program
    {
        public static Boolean isEmployeePresent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            if (isEmployeePresent())
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is not present");
        }
    }
}
