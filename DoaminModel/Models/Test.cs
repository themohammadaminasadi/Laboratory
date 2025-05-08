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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            InsuranceTests = new HashSet<InsuranceTest>();
            PatientTestDetails = new HashSet<PatientTestDetail>();
            TestRanges = new HashSet<TestRange>();
        }

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

        public long? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsuranceTest> InsuranceTests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientTestDetail> PatientTestDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestRange> TestRanges { get; set; }

        public virtual TestCategory TestCategory { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
