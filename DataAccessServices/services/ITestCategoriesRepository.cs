using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessServices.Services
{
    public interface ITestCategoriesRepository
    {
        bool HasCategoriesInTableTestCategories(int CategoryID);
        List<DoaminModel.ViewModel.CategoryTest.CategoryListItem> GetAllForComboFormTest();
        bool ExsistDupplicateCategoryName(string TestName);
    }
}
