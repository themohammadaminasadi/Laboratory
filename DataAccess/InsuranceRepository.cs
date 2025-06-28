using DataAccessServices.Services;
using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InsuranceRepository : IBaseRepository<Insurance, int>
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(Insurance Model)
        {
            try
            {
                db.Insurances.Add(Model);
                db.SaveChanges();
                return Model.InsuranceID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضاهف کردن به درستی انجام نشد خواهشمند است با پشتیبانی تماس بگیرید ");
            }
        }

        public bool Delete(int Key)
        {
            try
            {
                db.Insurances.Remove(db.Insurances.FirstOrDefault(x => x.InsuranceID == Key));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("عملیات حذف به درستی انجام نشد با پشتیبانی تماس بگیرید");
            }
        }

        public Insurance Get(int Key)
        {
            return db.Insurances.FirstOrDefault(x => x.InsuranceID == Key);
        }

        public List<Insurance> GetAll()
        {
            return db.Insurances.ToList();
        }

        public bool hasInsuranceInTableTemp(int InsuranceID)
        {
            return db.PaitentTestHeders.Any(x => x.InsuranceID == InsuranceID);
        }
        public bool hasInsuranceTableInsuranceType(int InsuranceID)
        {
            return db.InsuranceTests.Any(x => x.InsuraneID == InsuranceID);
        }
        public bool HasInuranceTypeNameInTableInsurance(string InsuranceTypeName)
        {
            return db.Insurances.Any(x => x.InsuranceTypeName == InsuranceTypeName);
        }

        public bool Update(Insurance NewModel)
        {
            try
            {
                var OldInsurance = db.Insurances.FirstOrDefault(x => x.InsuranceID == NewModel.InsuranceID);
                OldInsurance.InsuranceTypeName = NewModel.InsuranceTypeName;
                OldInsurance.Description = NewModel.Description;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("عملیات ویرایش با موفقیت انجام نشد با پشتیبانی تماس بگیرید");
            }
        }
    }
}
