using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoaminModel.Models
{
    public partial class LaboratoryContext : DbContext
    {
        public LaboratoryContext()
            : base("name=LaboratoryContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAction> EmployeeActions { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<InsuranceTest> InsuranceTests { get; set; }
        public virtual DbSet<PaitentTestHeder> PaitentTestHeders { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientTestDetail> PatientTestDetails { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestCategory> TestCategories { get; set; }
        public virtual DbSet<TestRange> TestRanges { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PaitentTestHeders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Insurance>()
                .HasMany(e => e.InsuranceTests)
                .WithRequired(e => e.Insurance)
                .HasForeignKey(e => e.InsuraneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Insurance>()
                .HasMany(e => e.PaitentTestHeders)
                .WithRequired(e => e.Insurance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaitentTestHeder>()
                .HasMany(e => e.PatientTestDetails)
                .WithRequired(e => e.PaitentTestHeder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.PaitentTestHeders)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.PaitentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.InsuranceTests)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.PatientTestDetails)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.TestRanges)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TestCategory>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.TestCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);
        }
    }
}
