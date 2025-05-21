using DoaminModel.Models;
using DoaminModel.ViewModel.TestRange;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface ITestRangeRepository
    {
        List<DoaminModel.ViewModel.TestRange.TestListItemForGridFormTestRange> GetAllFormTestRange();
        List<TestListItemForGridFormTestRange> Search(ListSearchItemForSearchPanelTestRange sm);
        List<TestRange> GetTestWithTestID(int TestID);
    }
}
