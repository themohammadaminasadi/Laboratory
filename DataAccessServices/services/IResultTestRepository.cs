using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IResultTestRepository
    {
        List<DoaminModel.ViewModel.ResultTest.ListItemResultTestHeader> GetAllPendingTests();
        List<ListItemTestDetails> GetDetails(int PatientHeaderID);
        bool setResult(int PatientDetailsID, double Result, bool HasStar);
        List<ListItemForListBox> SearchPatientByPatientName(string PatientName);
        List<ListItemForListBox> SearchPaitentByNationalCode(string NationalCode);
        List<ListItemForListBox> SearchPaitentByPatientHeaderTestID(int? PatientHeaderID);
        
    }
}
