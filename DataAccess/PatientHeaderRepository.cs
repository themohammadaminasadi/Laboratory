using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Patient;
using DoaminModel.ViewModel.PatientTest;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PatientHeaderRepository : IBaseRepository<PaitentTestHeder, int>, IPatientTestHederRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(PaitentTestHeder Model)
        {
            try
            {
                db.PaitentTestHeders.Add(Model);
                db.SaveChanges();
                return Model.PatientTestHederID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن با موفقیت انجام نشد با پشتیبانی تماس بگیرید");
            }
        }

        public int Add(PatientTestDetail patientTestDetail)
        {
            try
            {
                db.PatientTestDetails.Add(patientTestDetail);
                db.SaveChanges();
                return patientTestDetail.PatientTestDetailsID;
            }
            catch (Exception)
            {

                throw new Exception("عملیات اضافه کردن با مشکل رو به رو شد با پشتیبانی تماس بگیرید");
            }
        }

        public bool Delete(int Key)
        {
            db.PaitentTestHeders.Remove(db.PaitentTestHeders.FirstOrDefault(x => x.PatientTestHederID == Key));
            db.SaveChanges();
            return true;
        }

        public PaitentTestHeder Get(int Key)
        {
            return db.PaitentTestHeders.FirstOrDefault(x => x.PatientTestHederID==Key);
        }

        public List<PaitentTestHeder> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PatientTestDetailsListItem> GetAllForGirdFormVisit(int PatientTestHederID)
        {
            var q = from PT in db.PatientTestDetails.Where(x => x.PatientTestHederID == PatientTestHederID)
                    select new PatientTestDetailsListItem
                    {
                        PatientTestHederID = PT.PatientTestHederID,
                        PatientTestDetailsID = PT.PatientTestDetailsID,
                        TestID = PT.TestID,
                        Price = PT.Price,
                        TestName = PT.Test.TestName,
                        Discount = db.InsuranceTests.Where(x=>x.TestID == PT.TestID && x.InsuraneID == PT.PaitentTestHeder.InsuranceID).Select(x=>x.Discount).FirstOrDefault(),
                        InsuranceID = PT.PaitentTestHeder.InsuranceID
                    };
            return q.ToList();
        }

        public long GetTotalPrice(int PatientTestHederID)
        {
            return db.PatientTestDetails
             .Where(x => x.PatientTestHederID == PatientTestHederID)
             .Sum(x => (long?)x.Price) ?? 0; 
            //(long?) : if x.price is null when nullable && sum(x.price) if null is 0 
        }

        public List<PaitientSearchItem> SearchByMobile(string MobileName)
        {
            var q = from T in db.Patients select T;
            if (!string.IsNullOrEmpty(MobileName) && MobileName.StartsWith("09"))
            {
                q = q.Where(x => x.PhoneNumber.StartsWith(MobileName));
            }
            var Result = from Ps in q
                         select new PaitientSearchItem
                         {
                             PatientID = Ps.PatientID,
                             FullInfo = Ps.FirstName + "  " + Ps.LastName + "  " + Ps.PhoneNumber + "  " + Ps.NationalCode
                         };
            return Result.ToList();
        }

        public List<PaitientSearchItem> SearchByNationalCode(string NationalCode)
        {
            var q = from P in db.Patients select P;
            if (!string.IsNullOrEmpty(NationalCode))
            {
                q = q.Where(x => x.NationalCode.Contains(NationalCode));
            }
            var Result = from P in q
                         select new PaitientSearchItem
                         {
                             PatientID =  P.PatientID,
                             FullInfo = P.FirstName + "  " + P.LastName + "  " + P.PhoneNumber + "  " + P.NationalCode
                         };
            return Result.ToList(); 
        }

        public List<PaitientSearchItem> SearchByPatientName(string PatientName)
        {
            var q = from P in db.Patients select P;
            if (!string.IsNullOrEmpty(PatientName))
            {
                string Phrase = PatientName.Trim();
                q = q.Where(x => (x.FirstName + " " + x.LastName).Contains(Phrase));
            }
            var Result = from P in q
                         select new PaitientSearchItem
                         {
                             PatientID = P.PatientID,
                             FullInfo = P.FirstName + "  " + P.LastName + "  " + P.PhoneNumber + "  " + P.NationalCode
                         };
            return Result.ToList();
        }

        public bool Update(PaitentTestHeder NewModel)
        {
            throw new NotImplementedException();
        }
        public bool DeleteDetails(int patientTestDetailID)
        {
            try
            {
                db.PatientTestDetails.Remove(db.PatientTestDetails.FirstOrDefault(x => x.PatientTestDetailsID == patientTestDetailID));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw new Exception("با مدیر سیستم تماس بگیرید");
            }
         
        }

        public PatientTestDetail GetPatientDetails(int patientTestDetailID)
        {
            return db.PatientTestDetails.AsNoTracking().FirstOrDefault(x => x.PatientTestDetailsID == patientTestDetailID); //New
        }

        public bool UpdatePatientDetails(PatientTestDetail patientTestDetail)
        {
            var OldPatientTestDetails = db.PatientTestDetails.FirstOrDefault(x => x.PatientTestDetailsID == patientTestDetail.PatientTestDetailsID);
            OldPatientTestDetails.TestID = patientTestDetail.TestID;
            OldPatientTestDetails.Result = patientTestDetail.Result;
            OldPatientTestDetails.HasStar = patientTestDetail.HasStar;
            OldPatientTestDetails.PatientTestHederID = patientTestDetail.PatientTestHederID;
            OldPatientTestDetails.Price = patientTestDetail.Price;
            db.SaveChanges();
            return true;    
        }

        public bool ExsistDetailsForTestHeader(int PatientTestHederID)
        {
            return db.PatientTestDetails.Any(x => x.PatientTestHederID == PatientTestHederID);
        }
        public bool DeleteTestDetails(int patientTestDetailID)
        {
            db.PatientTestDetails.Remove(db.PatientTestDetails.FirstOrDefault(x => x.PatientTestDetailsID == patientTestDetailID));
            db.SaveChanges();
            return true;
        }

        public bool ExsistHeader(int PatientTestHederID)
        {
            return db.PaitentTestHeders.Any(x => x.PatientTestHederID == PatientTestHederID);
        }

        public List<ListItemResultTestHeader> GetPendingTestByPatientID(int PatientID)
        {
            return (from Header in db.PaitentTestHeders
                    where db.PatientTestDetails
                        .Any(d => d.PatientTestHederID == Header.PatientTestHederID && d.Result == null && Header.PaitentID == PatientID)
                    select new ListItemResultTestHeader
                    {
                        PatientTestHederID = Header.PatientTestHederID,
                        HederDate = Header.HederDate,
                        PaitentID = Header.PaitentID,
                        Age = Header.Age,
                        DrName = Header.DrName,
                        FullNamePaitent = Header.Patient.FirstName + " " + Header.Patient.LastName,
                        NationalCode = Header.Patient.NationalCode
                    }).ToList();
        }

        public bool ExsistTestInInsuranceTest(int InsuranceID, int TestID)
        {
            return db.InsuranceTests.Any(x => x.TestID == TestID && x.InsuraneID == InsuranceID);
        }
    }
}
