using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoaminModel.ViewModel.Order
{
    public class ItemsSearchOrderReport
    {
        public int PatientTestHederID { get; set; }
        public DateTime?  FromHederDate { get; set; }
        public DateTime?  ToHederDate { get; set; }
        public string FullName { get; set; }
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        public string DrName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumer { get; set; }
        public int InsuranceID { get; set; }
        public string Employee { get; set; }
        public bool? Gender { get; set; }
    }
}
