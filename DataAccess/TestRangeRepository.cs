using DataAccessServices.Services;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestRangeRepository : IBaseRepository<DoaminModel.Models.TestRange, int>
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

        public TestRange Get(int Key)
        {
            return db.TestRanges.FirstOrDefault(x => x.RangeID == Key);
        }

        public List<TestRange> GetAll()
        {
            return db.TestRanges.ToList();
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
