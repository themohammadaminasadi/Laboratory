using DoaminModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaminModel.ViewModel.Test
{
    public class TestListItem
    {
        public int TestID { get; set; }
        public string TestName { get; set; }

        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string AgeHasEfect { get; set; }

        public string GenderHasEfect { get; set; }

        public long? Price { get; set; }
    }
}
