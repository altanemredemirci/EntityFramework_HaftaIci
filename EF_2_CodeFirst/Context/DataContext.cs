using EF_2_CodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2_CodeFirst.Context
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLDERS; Database=NORTHWND; User Id=sa; Pwd=1; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandCategory>()
              .HasKey(i => new { i.BrandId, i.CategoryId });

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Barcode)
                .WithOne(i => i.Product)
                .HasForeignKey<Barcode>(i => i.ProductId);
                
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
    }
}
