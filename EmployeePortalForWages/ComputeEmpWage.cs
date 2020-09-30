using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortalForWages
{
    interface ComputeEmpWage
    {
        public void addCompanyWage(String company,Double empRatePerHour,Double numOfWorkingDays,Double workingHrs);

        public Double getTotalWage(string company);
    }
}
