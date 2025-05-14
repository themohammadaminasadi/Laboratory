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
            throw new NotImplementedException();
        }

        public List<PaitientSearchItem> SearchByNationalCode(string NationalCode)
        {
            throw new NotImplementedException();
        }

        public List<PaitientSearchItem> SearchByPatientName(string PatientName)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaitentTestHeder NewModel)
        {
            throw new NotImplementedException();
        }
    }
}
