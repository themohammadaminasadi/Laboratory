using DoaminModel.Models;
using DoaminModel.ViewModel.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public List<DoaminModel.ViewModel.Test.TestListItemForFormInsuranceTest> GetAllTestForListViewFormInsuranceTest(string sm)
        {
            var q = from T in db.Tests select T;
            if (!string.IsNullOrEmpty(sm))
            {
                q = q.Where(x => x.TestName.StartsWith(sm));
            }
            var result = from q1 in q
                         select new TestListItemForFormInsuranceTest
                         {
                             TestID = q1.TestID,
                             TestName = q1.TestName
                         };
            return result.ToList();
            
        }
        public Test Get(int key)
        {
            return db.Tests.FirstOrDefault(x => x.TestID == key);
        }
    }
}
