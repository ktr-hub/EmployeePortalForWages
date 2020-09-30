using System;
using System.Collections.Generic;

namespace EmployeePortalForWages
{
    class EmpWageBuilder:IComputeEmpWage
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 0;
        List<Company> companyList = new List<Company>();
        Dictionary<string, Company> companySalary = new Dictionary<string, Company>();
        public void addCompanyWage(String company, Double empRatePerHour, Double maxWorkingHrs,Double workingHrs)
        {
            Company companyObject = new Company(company, empRatePerHour,  maxWorkingHrs, workingHrs);
            companyList.Add(companyObject);
            companySalary.Add(company,companyObject);
        }

        public void setWage()
        {
            foreach(Company company in this.companyList)
            {
                company.setSalary(this.computeWage(company));
                company.toString();
            }
        }

        private Double computeWage(Company company)
        {
            Double maxDays = 20;
            Double totalHrs = 0;
            Double totalDays = 0;

            Random random = new Random();
            int empType = random.Next(0, 2);

            while (totalHrs < company.maxWorkingHrs && totalDays < maxDays)
            {
                switch (empType)
                {
                    case PART_TIME:
                        company.empRatePerHour = 80;
                        company.workingHrs = 8;
                        break;
                    default:
                        break;
                }
                totalHrs = totalHrs + company.workingHrs;
                totalDays++;
            }
            Double totalWage = totalHrs * company.empRatePerHour;
            Double DailyWage = company.workingHrs * company.empRatePerHour;
            company.setDailyWage(DailyWage);
            return totalWage;
        }

        public Double getTotalWage(string company)
        {

            return companySalary[company].getSalary();
        }

    }
}
