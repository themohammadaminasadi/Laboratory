namespace DoaminModel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LaboratoryContext : DbContext
    {
        public LaboratoryContext()
            : base("name=LaboratoryContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<TEMP> TEMPs { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestCategory> TestCategories { get; set; }
        public virtual DbSet<TestRange> TestRanges { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
