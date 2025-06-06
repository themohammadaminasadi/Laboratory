using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessServices.Services;
using DoaminModel.Models;

namespace DataAccess
{
    public class EmployeeActionRepository : IBaseRepository<EmployeeAction, int>
    {
        private LaboratoryContext db = new LaboratoryContext();
        public int Add(EmployeeAction Model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Key)
        {
            throw new NotImplementedException();
        }

        public EmployeeAction Get(int Key)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeAction> GetAll()
        {
            return db.EmployeeActions.ToList();  
        }

        public bool Update(EmployeeAction NewModel)
        {
            throw new NotImplementedException();
        }
    }
}
