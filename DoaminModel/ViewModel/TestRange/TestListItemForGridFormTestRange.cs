using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaminModel.ViewModel.TestRange
{
    public class TestListItemForGridFormTestRange
    {
        public int RangeID { get; set; }

        public string TestName { get; set; }

        public double? MinValue { get; set; }

        public double? MaxValue { get; set; }

        public string Gender { get; set; }

        public int? FromAge { get; set; }

        public int? ToAge { get; set; }

        public bool Hazard { get; set; }
       

    }
}
