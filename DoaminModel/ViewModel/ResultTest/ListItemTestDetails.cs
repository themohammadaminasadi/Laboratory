using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaminModel.ViewModel.ResultTest
{
    public class ListItemTestDetails
    {
        public int PatientTestDetailsID { get; set; }
        public int TestID { get; set; }
        public string TestName { get; set; }
        public double? Result { get; set; }
        public bool? HasStar { get; set; }
    }
}
