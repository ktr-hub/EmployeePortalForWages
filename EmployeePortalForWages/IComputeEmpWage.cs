using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    interface IComputeEmpWage
    {
        public void addCompanyWage(String company,Double empRatePerHour,Double numOfWorkingDays,Double workingHrs);

        public void setWage();

        public Double getTotalWage(string company);
    }
}
