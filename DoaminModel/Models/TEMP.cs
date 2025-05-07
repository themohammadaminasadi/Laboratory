namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEMP")]
    public partial class TEMP
    {
        public int ID { get; set; }

        public int TestID { get; set; }

        public int InsuraneID { get; set; }

        public int Discount { get; set; }
    }
}
