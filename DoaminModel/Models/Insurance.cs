namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Insurance")]
    public partial class Insurance
    {
        public int InsuranceID { get; set; }

        [Required]
        [StringLength(50)]
        public string InsuranceTypeName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
