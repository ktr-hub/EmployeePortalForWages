using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    class Company
    {
        public String company;
        public Double empRatePerHour;
        public Double numOfWorkingDays;
        public Double workingHrs;
        public Double salary;
        public Company(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
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

        public string toString()
        {
            return (this.company + " salary is " + this.salary);
        }

    }
}
