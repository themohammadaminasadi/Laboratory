using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.TestRange;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestRangeRepository : IBaseRepository<DoaminModel.Models.TestRange, int>,ITestRangeRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(TestRange Model)
        {
            try
            {
                db.TestRanges.Add(Model);
                db.SaveChanges();
                return Model.RangeID;
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
                db.TestRanges.Remove(db.TestRanges.FirstOrDefault(x => x.RangeID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با موفقیت انجام نشد خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }

        public bool ExsistLogInOtherTable(int TestID)
        {
            return db.Tests.Any(x => x.TestID == TestID);
        }

        public TestRange Get(int Key)
        {
            return db.TestRanges.FirstOrDefault(x => x.RangeID == Key);
        }

        public List<TestRange> GetAll()
        {
            return db.TestRanges.ToList();
        }

        public List<TestListItemForGridFormTestRange> GetAllFormTestRange()
        {
            var q = from TR in db.TestRanges select new TestListItemForGridFormTestRange
            {
                TestName = TR.Test.TestName,
                RangeID = TR.RangeID,
                MinValue = TR.MinValue,
                MaxValue = TR.MaxValue,
                FromAge = TR.FromAge,
                TestID = TR.TestID,
                ToAge = TR.ToAge,
                Hazard = TR.Hazard,
                Gender = TR.Gender == 1 ? "مرد" :
                         TR.Gender == 0 ? "زن" :
                         TR.Gender == 3 ? "همه" : "نامشخص"
            };
            return q.ToList();
        }

        public List<TestRange> GetTestWithTestID(int TestID)
        {
            return db.TestRanges.Where(x => x.TestID == TestID).ToList();
        }

        public List<TestListItemForGridFormTestRange> Search(ListSearchItemForSearchPanelTestRange sm)
        {
            var q = from TR in db.TestRanges select TR;
            if (!string.IsNullOrEmpty(sm.TestName))
            {
                q = q.Where(x => x.Test.TestName.StartsWith(sm.TestName));
            }
            if (sm.MinValue != null)
            {
                q = q.Where(x => x.MinValue >= sm.MinValue);
            }
            if (sm.MaxValue != null)
            {
                q = q.Where(x => x.MaxValue <= sm.MaxValue);
            }
            if (sm.FromAge != null)
            {
                q = q.Where(x => x.FromAge >= sm.FromAge);
            }
            if (sm.ToAge != null)
            {
                q = q.Where(x => x.ToAge <= sm.ToAge);
            }
            
            var Result = from TR in q
                         select new TestListItemForGridFormTestRange
                         {
                             RangeID = TR.RangeID,
                             MinValue = TR.MinValue,
                             MaxValue = TR.MaxValue,
                             FromAge = TR.FromAge,
                             ToAge = TR.ToAge,
                             Hazard = TR.Hazard,
                             TestName = TR.Test.TestName,
                             Gender = TR.Gender == 1 ? "مرد" :
                             TR.Gender == 0 ? "زن" :
                             TR.Gender == 3 ? "همه" : "نامشخص"
                         };
            return Result.ToList();
        }

        public bool Update(TestRange NewModel)
        {
            try
            {
                var OldTestRange = db.TestRanges.FirstOrDefault(x => x.RangeID == NewModel.RangeID);
                OldTestRange.TestID = NewModel.TestID;
                OldTestRange.MinValue = NewModel.MinValue;
                OldTestRange.MaxValue = NewModel.MaxValue;
                OldTestRange.Gender = NewModel.Gender;
                OldTestRange.FromAge = NewModel.FromAge;
                OldTestRange.ToAge = NewModel.ToAge;
                OldTestRange.Hazard = NewModel.Hazard;
                OldTestRange.Description = NewModel.Description;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات ویرایش با موفقیت انجام نشد خواهشمند است با پشتبیانی تماس بگیرید");
            }
        }
    }
}
