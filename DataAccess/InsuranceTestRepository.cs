using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.InsuranceTest;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InsuranceTestRepository : IBaseRepository<InsuranceTest, int>,IInsuranceTestRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(InsuranceTest Model)
        {
            try
            {
                db.InsuranceTests.Add(Model);
                db.SaveChanges();
                return Model.InsuranceTestID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن با مشکل رو به رو شد با پشتیبانی تماس بگیرید");

            }
        }

        public bool Delete(int Key)
        {
            try
            {
                db.InsuranceTests.Remove(db.InsuranceTests.FirstOrDefault(x => x.InsuranceTestID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با مشکل رو به رو شد با پشتیبانی تماس بگیرید");
            }
        }

        public InsuranceTest Get(int Key)
        {
            return db.InsuranceTests.FirstOrDefault(x => x.InsuranceTestID == Key);
        }

        public InsuranceTest Get(int InsuranceID, int TestID)
        {
            return db.InsuranceTests.FirstOrDefault(x => x.InsuraneID == InsuranceID && x.TestID == TestID);
        }

        public List<InsuranceTest> GetAll()
        {
            return db.InsuranceTests.ToList();
        }

        public List<InsuranceTestListItem> GetAllFromViewModel()
        {
            var q = from In in db.InsuranceTests
                    select new DoaminModel.ViewModel.InsuranceTest.InsuranceTestListItem
                    {
                        InsuranceTestID = In.InsuranceTestID,
                        InsuranceType = In.Insurance.InsuranceTypeName,
                        TestName = In.Test.TestName,
                        Year = In.Year,
                        Discount = In.Discount
                    };
            return q.ToList();
        }

        public bool Update(InsuranceTest NewModel)
        {
            try
            {
                var OldInsuranceTest = db.InsuranceTests.FirstOrDefault(x => x.InsuranceTestID == NewModel.InsuranceTestID);
                OldInsuranceTest.InsuraneID = NewModel.InsuraneID;
                OldInsuranceTest.TestID = NewModel.TestID;
                OldInsuranceTest.Year = NewModel.Year;
                OldInsuranceTest.Discount = NewModel.Discount;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با مشکل رو به رو شد خواهشمند است با پشتیبانی تماس بگیرید");
            }
        }
    }
}
