using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    class Company
    {
        public String company;
        public Double empRatePerHour;
        public Double maxWorkingHrs;
        public Double workingHrs;
        public Double salary; //monthly
        public Double dailyWage;
        public Company(String company, Double empRatePerHour, Double maxWorkingHrs, Double workingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingHrs = maxWorkingHrs;
            this.workingHrs = workingHrs;
        }
        public void setSalary(Double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }

        public void setDailyWage(Double dailyWage)
        {
            this.dailyWage = dailyWage;
        }

        public double getDailyWage()
        {
            return this.dailyWage;
        }

        public void toString()
        {
            Console.WriteLine(this.company + " Daily Salary " + this.dailyWage);
            Console.WriteLine(this.company + " Monthly Salary " + this.salary);
        }

    }
}
