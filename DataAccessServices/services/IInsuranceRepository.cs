using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessServices.Services
{
    public interface IInsuranceRepository
    {

        bool hasInsuranceInTableTemp(int InsuranceID);
        bool HasInuranceTypeNameInTableInsurance(string InuranceTypeName);

    }
}
