using DoaminModel.Models;
using DoaminModel.ViewModel.Patient;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IPatientTestHederRepository
    {
        List<PaitientSearchItem> SearchByMobile(string MobileName);
        List<PaitientSearchItem> SearchByPatientName(string PatientName);
        List<PaitientSearchItem> SearchByNationalCode(string NationalCode);
        int Add(PatientTestDetail patientTestDetail);
        List<DoaminModel.ViewModel.PatientTest.PatientTestDetailsListItem> GetAllForGirdFormVisit(int PatientTestHederID);
        long GetTotalPrice(int PatientTestHederID);
        bool DeleteDetails(int patientTestDetailID);
        PatientTestDetail GetPatientDetails(int patientTestDetailID);
        bool UpdatePatientDetails(PatientTestDetail patientTestDetail);
        bool ExsistDetailsForTestHeader(int PatientTestHederID);
        bool DeleteTestDetails(int patientTestDetailID);
        bool ExsistHeader(int PatientTestHederID);
        List<ListItemResultTestHeader> GetPendingTestByPatientID(int PatientID);
        bool ExsistTestInInsuranceTest(int InsuranceID, int TestID);
        bool ExsistTestInPatientTestDetails(int TestID , int PatientTestHeaderID);
    }
}
