using DoaminModel.Models;
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
    }
}
