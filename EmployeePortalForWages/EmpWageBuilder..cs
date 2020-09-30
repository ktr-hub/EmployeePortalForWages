using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    class EmpWageBuilder:IComputeEmpWage
    {
        List<Company> companyList = new List<Company>();
        Dictionary<string, Company> companySalary = new Dictionary<string, Company>();
        public void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs)
        {
            Company companyObject = new Company(company, empRatePerHour,  numOfWorkingDays, workingHrs);
            companyList.Add(companyObject);
            companySalary.Add(company,companyObject);
        }

        public void setWage()
        {
            foreach(Company company in this.companyList)
            {
                company.setSalary(this.computeWage(company));
                Console.WriteLine(company.toString());
            }
        }

        private Double computeWage(Company company)
        {
            return company.empRatePerHour *  company.numOfWorkingDays * company.workingHrs;
        }

        public Double getTotalWage(string company)
        {
            return companySalary[company].getSalary();
        }
    }
}
