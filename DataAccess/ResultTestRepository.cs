using DataAccessServices.services;
using DoaminModel.Models;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ResultTestRepository : IResultTestRepository
    {
        private LaboratoryContext db = new LaboratoryContext();
        public List<ListItemResultTestHeader> GetAllPendingTests()
        {
            return (from Header in db.PaitentTestHeders
                    where db.PatientTestDetails
                        .Any(d => d.PatientTestHederID == Header.PatientTestHederID && d.Result == null)
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

        public List<ListItemTestDetails> GetDetails(int PatientHeaderID)
        {
            return (from Details in db.PatientTestDetails
                    where Details.PatientTestHederID == PatientHeaderID
                    select new ListItemTestDetails
                    {
                        PatientTestDetailsID = Details.PatientTestDetailsID,
                        TestID = Details.TestID,
                        TestName = Details.Test.TestName,
                        HasStar = Details.HasStar,
                        Result = Details.Result
                    }).ToList();
        }

        public bool setResult(int PatientDetailsID, double Result, bool HasStar)
        {
            var OldPatientDetails = db.PatientTestDetails.FirstOrDefault(x => x.PatientTestDetailsID == PatientDetailsID);
            if (OldPatientDetails == null)
            {
                return false;
            }
            OldPatientDetails.HasStar = HasStar;
            OldPatientDetails.Result = Result;
            db.SaveChanges();
            return true;
        }
    }
}
