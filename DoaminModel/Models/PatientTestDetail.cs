namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientTestDetail")]
    public partial class PatientTestDetail
    {
        [Key]
        public int PatientTestDetailsID { get; set; }

        public int PatientTestHederID { get; set; }

        public int TestID { get; set; }

        public long Price { get; set; }

        public double? Result { get; set; }

        public bool? HasStar { get; set; }

        public virtual PaitentTestHeder PaitentTestHeder { get; set; }

        public virtual Test Test { get; set; }
    }
}
