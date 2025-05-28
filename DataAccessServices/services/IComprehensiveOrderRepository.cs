using DoaminModel.Models;
using DoaminModel.ViewModel.Order;
using DoaminModel.ViewModel.ResultTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessServices.services
{
    public interface IComprehensiveOrderRepository
    {
        List<ListItemResultTestHeader> SearchComprehensiveOrderForPushDataGridTestHeader(ItemsSearchOrderReport ls);
        List<PatientTestDetail> GetPatientDetailsForCalcualteTotalPrice(int PatientTestHederID);
        decimal TotalPriceForComprehensiveOrderReport(int PatientTestHederID);
        
    }
}
