using DoaminModel.ViewModel.Patient;
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
    }
}
