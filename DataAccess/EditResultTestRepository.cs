using DataAccessServices.services;
using DoaminModel.Models;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EditResultTestRepository : IEditResultTestRepository
    {
        private LaboratoryContext db = new LaboratoryContext();

        public List<ListItemResultTestHeader> GetPatientTestByPatientID(int PatientID)
        {
            return (from Header in db.PaitentTestHeders
                    where Header.PaitentID == PatientID
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
        public List<ListItemForListBox> SearchPatientTestHeaderForFrmEditResultTest(string sm)
        {
            if (!string.IsNullOrEmpty(sm))
            {
                var q = from PT in db.PaitentTestHeders select PT;
                q = q.Where(x => (x.Patient.FirstName + " " + x.Patient.LastName).Contains(sm));
                var result = from q1 in q
                             select new ListItemForListBox
                             {
                                 PatientID = q1.PaitentID,
                                 FullInfoPatient = q1.Patient.FirstName + "   " + q1.Patient.LastName + "  " + q1.Patient.Age + "  " + q1.Patient.PhoneNumber
                             };
                return  result.Distinct().ToList();
            }
            else
            {
                return new List<ListItemForListBox>();
            }
        }

        public List<ListItemResultTestHeader> SearchPatientWithDateTimeTestHeaderForFrmEditResultTest(DateTime sm)
        {
            if (sm != null)
            {
                var q = from Q in db.PaitentTestHeders select Q;
                q = q.Where(x => x.HederDate == sm);
                var result = from q1 in q
                             select new ListItemResultTestHeader
                             {
                                 PaitentID = q1.PaitentID,
                                 PatientTestHederID = q1.PatientTestHederID,
                                 FullNamePaitent = q1.Patient.FirstName + " " + q1.Patient.LastName,
                                 Age = q1.Age,
                                 DrName = q1.DrName,
                                 HederDate = q1.HederDate,
                                 NationalCode = q1.NationalCode
                             };
                return result.Distinct().ToList();

            }
            else
            {
                return new List<ListItemResultTestHeader>();
            }
        }

        public List<ListItemForListBox> SearchPatientWithMobileNmuberTestHeaderForFrmEditResultTest(string sm)
        {
            if (!string.IsNullOrEmpty(sm))
            {
                var q = from Q in db.PaitentTestHeders select Q;
                q = q.Where(x => x.Patient.PhoneNumber.StartsWith(sm));
                var result = from q1 in q
                             select new ListItemForListBox
                             {
                                 PatientID = q1.PaitentID,
                                 FullInfoPatient = q1.Patient.FirstName + "   " + q1.Patient.LastName + "  " + q1.Patient.Age + "  " + q1.Patient.PhoneNumber
                             };
                return result.Distinct().ToList();

            }
            else
            {
                return new List<ListItemForListBox>();
            }
        }


        public List<ListItemForListBox> SearchPatientWithNationalCodeTestHeaderForFrmEditResultTest(string sm)
        {
            if (!string.IsNullOrEmpty(sm))
            {
                var q = from Q in db.PaitentTestHeders select Q;
                q = q.Where(x => x.NationalCode.StartsWith(sm));
                var result = from q1 in q
                             select new ListItemForListBox
                             {
                                 PatientID = q1.PaitentID,
                                 FullInfoPatient = q1.Patient.FirstName + "   " + q1.Patient.LastName + "  " + q1.Patient.Age + "  " + q1.Patient.PhoneNumber
                             };
                return result.Distinct().ToList();

            }
            else
            {
                return new List<ListItemForListBox>();
            }
        }
    }
}
