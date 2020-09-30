using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    class EmpWageBuilder:ComputeEmpWage
    {
        Dictionary<string, Double> companySalary;
        public void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            Company companyObject = new Company(company, empRatePerHour,  numOfWorkingDays, workingHrs);
            companySalary = new Dictionary<string, double>();
            companySalary[company] = empRatePerHour * numOfWorkingDays * workingHrs;
        }

        public Double getTotalWage(string company)
        {
            return companySalary[company];
        }
    }
}
