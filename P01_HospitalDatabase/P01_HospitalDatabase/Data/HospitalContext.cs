using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using P01_HospitalDatabase.Data.Models;
using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() { }
        public HospitalContext(DbContextOptions options)
            : base(options) { }


        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PatientMedicament> PatientsMedicaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConentionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);

                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Address).IsRequired().HasMaxLength(250);

                entity.Property(e => e.Email).IsRequired().IsUnicode(false).HasMaxLength(80);

                entity.Property(e => e.HasInsurance).HasDefaultValue(true);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.Property(e => e.Specialty).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Visitation>(entity =>
            {
                entity.Property(e => e.Date).HasColumnName("VisitationDate").IsRequired().HasColumnType("DATETIME2").HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.Comments).IsRequired(false).HasMaxLength(250);

                entity.HasOne(e => e.Patient).WithMany(p => p.Visitations).HasForeignKey(e => e.PatientId);

                entity.Property(e => e.DoctorId).IsRequired(false);

                entity.HasOne(e => e.Doctor).WithMany(d => d.Visitations).HasForeignKey(e => e.DoctorId);
            });

            modelBuilder.Entity<Diagnose>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Comments).IsRequired(false).HasMaxLength(250);

                entity.HasOne(e => e.Patient).WithMany(p => p.Diagnoses).HasForeignKey(e => e.PatientId);
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<PatientMedicament>(entity =>
            {
                entity.HasKey(e => new { e.MedicamentId, e.PatientId });

                entity.HasOne(e => e.Patient).WithMany(p => p.Prescriptions).HasForeignKey(e => e.PatientId);

                entity.HasOne(e => e.Medicament).WithMany(m => m.Prescriptions).HasForeignKey(e => e.MedicamentId);
            });
        }
    }
}
