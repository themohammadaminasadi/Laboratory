using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IEditResultTestRepository
    {
        List<ListItemForListBox> SearchPatientTestHeaderForFrmEditResultTest(string sm);
        List<ListItemForListBox> SearchPatientWithNationalCodeTestHeaderForFrmEditResultTest(string sm);
        List<ListItemForListBox> SearchPatientWithMobileNmuberTestHeaderForFrmEditResultTest(string sm);
        List<ListItemResultTestHeader> SearchPatientWithDateTimeTestHeaderForFrmEditResultTest(DateTime sm);
        List<ListItemResultTestHeader> GetPatientTestByPatientID(int PatientID);

    }
}
