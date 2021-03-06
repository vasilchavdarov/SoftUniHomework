﻿using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() { }
        public StudentSystemContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> HomeworkSubmissions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-0NSKHNUT\\SQLEXPRESS;Database=StudentSystem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired(false).IsUnicode(false).HasColumnType("CHAR(10)");

                entity.Property(e => e.Birthday).IsRequired(false);

            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(80).IsRequired();

                entity.Property(e => e.Description).IsRequired(false).HasMaxLength(80);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Url).IsUnicode(false);

                entity.HasOne(e => e.Course).WithMany(c => c.Resources).HasForeignKey(e => e.CourseId);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Content).IsUnicode(false);

                entity.HasOne(e => e.Student).WithMany(s => s.HomeworkSubmissions).HasForeignKey(e => e.StudentId);

                entity.HasOne(e => e.Course).WithMany(c => c.HomeworkSubmissions).HasForeignKey(e => e.CourseId);
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.StudentId });

                entity.HasOne(e => e.Student).WithMany(s => s.CourseEnrollments).HasForeignKey(e => e.CourseId);

                entity.HasOne(e => e.Course).WithMany(c => c.StudentsEnrolled).HasForeignKey(e => e.StudentId);
            });
        }
    }
}
