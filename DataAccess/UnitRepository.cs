using DateAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Test;
using DoaminModel.ViewModel.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitRepository : DataAccessServices.Services.IBaseRepository<Unit, int>, IUnitRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(Unit Model)
        {
            try
            {
                db.Units.Add(Model);
                db.SaveChanges();
                return Model.UnitID;
            }
            catch (Exception)
            {
                throw new Exception("عملیات اضافه کردن واحد آزمایش درست انجام نشد با پشتیبانی تماس حاصل کنید");
            }
        }

        public bool Delete(int Key)
        {
            try
            {
                db.Units.Remove(db.Units.FirstOrDefault(x => x.UnitID == Key));
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw new Exception("عملیات حذف درست انجام نشد با پشتیبانی تماس حاصل کنید");
            }
        }

        public Unit Get(int Key)
        {
            return db.Units.FirstOrDefault(x => x.UnitID == Key);
        }

        public List<Unit> GetAll()
        {
            return db.Units.ToList();
        }

        public bool Update(Unit NewModel)
        {
            try
            {

                var OldUnit = db.Units.FirstOrDefault(x => x.UnitID == NewModel.UnitID);
                OldUnit.UnitName = NewModel.UnitName;
                return true;
            }
            catch (Exception)
            {

                throw new Exception("واحد ویرایش نشده است لطفاً با پشتیبانی تماس حاصل کنید");
            }
        }
        public bool HasUnitInTest(int UnitID)
        {
            return db.Tests.Any(x => x.UnitID == UnitID);
        }
        public List<DoaminModel.ViewModel.Unit.UnitListForSearchInformTest> SearchUnitForFormTest(string sm)
        {
            var q = from U in db.Units select U;
            if (!string.IsNullOrEmpty(sm))
            {
                q = q.Where(x => x.UnitName.StartsWith(sm));
            }
            var result = from q1 in q
                         select new UnitListForSearchInformTest
                         {
                             UnitID = q1.UnitID,
                             UnitName = q1.UnitName
                         };
            return result.ToList();

        }
    }
}
