using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess
{
    public class TestRepository:IBaseRepository<Test,int>,ITestRepository
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

        public List<Test> GetAll()
        {
            return db.Tests.ToList();
        }

        public int Add(Test Model)
        {
            try
            {
                db.Tests.Add(Model);
                db.SaveChanges();
                return Model.TestID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن با موفقیت انجام نشد خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }

        public bool Delete(int Key)
        {
            try
            {
                db.Tests.Remove(db.Tests.FirstOrDefault(x => x.TestID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با موفقیت انجام نشد با پشتیبانی تماس بگیرید");
            }
        }

        public bool Update(Test NewModel)
        {
            try
            {
                var OldTest = db.Tests.FirstOrDefault(x => x.TestID == NewModel.TestID);
                OldTest.TestName = NewModel.TestName;
                OldTest.UnitID = NewModel.UnitID;
                OldTest.CategoryID = NewModel.CategoryID;
                OldTest.AgeHasEfect = NewModel.AgeHasEfect;
                OldTest.GenderHasEfect = NewModel.GenderHasEfect;
                OldTest.Description = NewModel.Description;
                OldTest.Price = NewModel.Price;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات ویرایش با موفقیت انجام نشد خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }

        public List<TestListItem> GetAllTestListForGrid()
        {
            var q = from T in db.Tests select new TestListItem
            {
                TestID = T.TestID,
                TestName = T.TestName,
                Price = T.Price,
                CategoryID = T.CategoryID,
                UnitID = T.UnitID,
                CategoryName = T.TestCategory.CategoryName,
                UnitName = T.Unit.UnitName,
                AgeHasEfect = T.AgeHasEfect == true ? "دارد" : (T.AgeHasEfect == false ? "ندارد" : "مشخص نیست"),
                GenderHasEfect = T.GenderHasEfect == true ? "دارد" : (T.GenderHasEfect == false ? "ندارد" : "مشخص نیست")
            };
            return q.ToList();
        }

        public bool ExsistTestInTableTestRange(int TestID)
        {
            return db.TestRanges.Any(x => x.TestID == TestID);
        }

        public List<TestListItem> SearchFormTest(TestListItemSearchForFormTest sm)
        {
            var q = from T in db.Tests select T;
            if (!string.IsNullOrEmpty(sm.TestName))
            {
                q = q.Where(x => x.TestName.Contains(sm.TestName));
            }
            if (sm.FromPrice != null)
            {
                q = q.Where(x => x.Price >= sm.FromPrice);
            }
            if (sm.ToPrice != null)
            {
                q = q.Where(x => x.Price <= sm.ToPrice);
            }
            if (!string.IsNullOrEmpty(sm.UnitName))
            {
                q = q.Where(x => x.Unit.UnitName.StartsWith(sm.UnitName));
            }
            var Result = from R in q
                         select new TestListItem
                         {
                             TestID = R.TestID,
                             TestName = R.TestName,
                             Price = R.Price,
                             CategoryID = R.CategoryID,
                             UnitID = R.UnitID,
                             CategoryName = R.TestCategory.CategoryName,
                             UnitName = R.Unit.UnitName,
                             AgeHasEfect = R.AgeHasEfect == true ? "دارد" : (R.AgeHasEfect == false ? "ندارد" : "مشخص نیست"),
                             GenderHasEfect = R.GenderHasEfect == true ? "دارد" : (R.GenderHasEfect == false ? "ندارد" : "مشخص نیست")

                         };
            return Result.ToList();
        }

        public List<TestListItemForListBoxFormTestRange> GetAllTestForListBoxFormTestRange(string TestName)
        {
            var q = from T in db.Tests select T;
            if (!string.IsNullOrEmpty(TestName))
            {
                q = q.Where(x => x.TestName.StartsWith(TestName));
            }
            var Result = from T1 in q
                         select new TestListItemForListBoxFormTestRange
                         {
                             FullInfoTest = T1.TestName + "             " +
                             (T1.GenderHasEfect == true ? "تأثیر دارد" :
                             T1.GenderHasEfect == false ? "تأثیر ندارد" :
                             "مشخص نیست"),
                             TestID = T1.TestID
                         };
            return Result.ToList();
        }
    }
}
