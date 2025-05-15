using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaminModel.ViewModel.PatientTest
{
    public class PatientTestDetailsListItem
    {
        public int PatientTestDetailsID { get; set; }
        public int PatientTestHederID { get; set; }
        public int TestID { get; set; }
        public string TestName { get; set; }
        public long Price { get; set; }
        public int Discount { get; set; }
        public int InsuranceID { get; set; }

    }
}
