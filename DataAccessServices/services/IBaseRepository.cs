using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.Services
{
    public interface IBaseRepository<TModel , Tkey>
    {
        //TModel is Table
        //Tkey is Argument
        TModel Get(Tkey Key);
        List<TModel> GetAll();

        int Add(TModel Model);

        bool Delete(Tkey Key);

        bool Update(TModel NewModel);
    }
}
