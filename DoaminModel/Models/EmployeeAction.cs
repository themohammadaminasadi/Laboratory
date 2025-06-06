namespace DoaminModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAction")]
    public partial class EmployeeAction
    {
        public int EmployeeActionID { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployeeActionName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
