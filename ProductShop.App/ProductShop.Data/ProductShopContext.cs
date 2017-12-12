using Microsoft.EntityFrameworkCore;
using ProductShop.Models;
using System;

namespace ProductShop.Data
{
    public class ProductShopContext : DbContext
    {
        public ProductShopContext()
        {

        }

        public ProductShopContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<CategoryProduct> CatecoryProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConecntionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired(false);
                entity.Property(e => e.LastName).IsRequired(true);
                entity.Property(e => e.Age).IsRequired(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.BuyerId).IsRequired(false);

                entity.HasOne(e => e.Buyer).WithMany(b => b.BoughtProducts).HasForeignKey(e => e.BuyerId);

                entity.HasOne(e => e.Seller).WithMany(b => b.SoldProducts).HasForeignKey(e => e.SellerId);

            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(15);
            });

            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.ProductId });

                entity.HasOne(e => e.Categorie).WithMany(c => c.Products).HasForeignKey(e => e.CategoryId);

                entity.HasOne(e => e.Product).WithMany(p => p.Categories).HasForeignKey(e => e.ProductId);
            });
        }

    }
}
