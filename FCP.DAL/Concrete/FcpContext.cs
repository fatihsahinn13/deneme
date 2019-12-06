using FCP.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCP.DAL.Concrete
{
    public class FcpContext : DbContext
    {
        public FcpContext()
        {
        }

        public FcpContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1; Database=FCPDB; uid=sa; pwd=123");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().ToTable("Products");
        //    modelBuilder.Entity<Category>().ToTable("Categories");
        //    modelBuilder.Entity<Supplier>().ToTable("Suppliers");
        //}
    }
}
