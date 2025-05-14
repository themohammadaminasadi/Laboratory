using DataAccessServices.services;
using DataAccessServices.Services;
using DoaminModel.Models;
using DoaminModel.ViewModel.Patient;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public bool Delete(int Key)
        {
            throw new NotImplementedException();
        }

        public PaitentTestHeder Get(int Key)
        {
            throw new NotImplementedException();
        }

        public List<PaitentTestHeder> GetAll()
        {
            throw new NotImplementedException();
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
    }
}
