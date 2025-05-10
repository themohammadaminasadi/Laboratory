using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface ITestRepository
    {
        List<DoaminModel.ViewModel.Test.TestListItem> GetAllTestListForGrid();

        List<DoaminModel.ViewModel.Test.TestListItemForFormInsuranceTest> GetAllTestForListViewFormInsuranceTest(string sm);
    }
}
