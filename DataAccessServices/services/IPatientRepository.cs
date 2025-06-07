using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IPatientRepository
    {
        //if Exsist In Other Table 
        bool HasExsistInPatientHear(int PatientID);

        List<Patient> SearchWtihItem(DoaminModel.ViewModel.Patient.PatientSearchItemForPanelSearch sm);
    }
}
