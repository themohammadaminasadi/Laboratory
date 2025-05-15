using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IInsuranceTestRepository
    {
         List<DoaminModel.ViewModel.InsuranceTest.InsuranceTestListItem> GetAllFromViewModel();
         InsuranceTest Get(int InsuranceID, int TestID);
    }
}
