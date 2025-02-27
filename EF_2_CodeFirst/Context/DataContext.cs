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

        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}
