using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext() { }
        public SalesContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConecntionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Quantity).IsRequired();

                entity.Property(e => e.Price).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(250).HasDefaultValueSql("No description");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.Property(e => e.Email).IsRequired().IsUnicode(false).HasMaxLength(80);
            });
            
            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(80);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.Property(e => e.Date).IsRequired().HasDefaultValueSql("GETDATE()");

                entity.HasOne(e => e.Product).WithMany(p => p.Sales).HasForeignKey(e => e.ProductId);

                entity.HasOne(e => e.Customer).WithMany(p => p.Sales).HasForeignKey(e => e.CustomerId);

                entity.HasOne(e => e.Store).WithMany(p => p.Sales).HasForeignKey(e => e.StoreId);
            });
        }

    }
}
