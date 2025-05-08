namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestRange")]
    public partial class TestRange
    {
        [Key]
        public int RangeID { get; set; }

        public int TestID { get; set; }

        public double? MinValue { get; set; }

        public double? MaxValue { get; set; }

        public int Gender { get; set; }

        public int? FromAge { get; set; }

        public int? ToAge { get; set; }

        public bool Hazard { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public virtual Test Test { get; set; }
    }
}
