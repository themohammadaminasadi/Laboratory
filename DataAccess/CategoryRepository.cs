using DataAccessServices.Services;
using DateAccessServices.Services;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryRepository : IBaseRepository<TestCategory, int>, ITestCategoriesRepository
    {
        private DoaminModel.Models.LaboratoryContext db = new LaboratoryContext();
        public int Add(TestCategory Model)
        {
            try
            {
                db.TestCategories.Add(Model);
                db.SaveChanges();
                return Model.CategoryID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با موفقیت انجام نشد با پشتیبانی تماس حاصل فرمایید");
            }

        }

        public bool Delete(int Key)
        {
            try
            {
                db.TestCategories.Remove(db.TestCategories.FirstOrDefault(x => x.CategoryID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف با موفقت انجام نشد با پشتیبانی تماس حاصل فرمایید.");
            }

        }

        public TestCategory Get(int Key)
        {
            return db.TestCategories.FirstOrDefault(x => x.CategoryID == Key);
        }

        public List<TestCategory> GetAll()
        {
            return db.TestCategories.ToList();
        }

        public bool HasCategoriesInTableTestCategories(int CategoryID)
        {
            return db.Tests.Any(x => x.CategoryID == CategoryID);
        }

        public bool Update(TestCategory NewModel)
        {
            try
            {
                var OldCategory = db.TestCategories.FirstOrDefault(x => x.CategoryID == NewModel.CategoryID);
                OldCategory.CategoryName = NewModel.CategoryName;
                db.SaveChanges();
                return false;
            }
            catch (Exception)
            {

                throw new Exception("عملیات ویرایش شکست خورد با پشتیبانی تماس بگیرید");
            }
        }
    }
}
