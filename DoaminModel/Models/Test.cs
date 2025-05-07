namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        public int TestID { get; set; }

        [Required]
        [StringLength(200)]
        public string TestName { get; set; }

        public int UnitID { get; set; }

        public int CategoryID { get; set; }

        public bool? AgeHasEfect { get; set; }

        public bool? GenderHasEfect { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
