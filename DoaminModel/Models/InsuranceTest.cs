namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InsuranceTest")]
    public partial class InsuranceTest
    {
        public int InsuranceTestID { get; set; }

        public int TestID { get; set; }

        public int InsuraneID { get; set; }

        public int Discount { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        public virtual Insurance Insurance { get; set; }

        public virtual Test Test { get; set; }
    }
}
