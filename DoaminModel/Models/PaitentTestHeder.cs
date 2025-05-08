namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaitentTestHeder")]
    public partial class PaitentTestHeder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaitentTestHeder()
        {
            PatientTestDetails = new HashSet<PatientTestDetail>();
        }

        [Key]
        public int PatientTestHederID { get; set; }

        public DateTime? HederDate { get; set; }

        public int PaitentID { get; set; }

        public int EmployeeID { get; set; }

        public int InsuranceID { get; set; }

        [Required]
        [StringLength(50)]
        public string DrName { get; set; }

        [Required]
        [StringLength(20)]
        public string NationalCode { get; set; }

        public int Age { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Insurance Insurance { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientTestDetail> PatientTestDetails { get; set; }
    }
}
