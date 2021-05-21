using DepartmentalStoreApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Data
{
    public class DepartmentalStoreContext:DbContext
    {

        public DbSet<Role> Role { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Server=localhost;Database=DStore;Username=postgres;Password=rana@1998");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //role table
            modelBuilder.Entity<Role>().HasKey(r => r.Id);
            modelBuilder.Entity<Role>().Property(r => r.RoleName).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<Role>().Property(r => r.Description).HasMaxLength(50);

            //address table
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Address>().Property(a => a.AddressLine1).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.AddressLine2).HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(a => a.City).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.State).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.PinCode).HasMaxLength(10).IsRequired();

            //staff table
            modelBuilder.Entity<Staff>().HasKey(s => s.Id);
            modelBuilder.Entity<Staff>().Property(s => s.Firstname).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Staff>().Property(s => s.LastName).HasMaxLength(30);
            modelBuilder.Entity<Staff>().Property(s => s.Gender).HasMaxLength(1);
            modelBuilder.Entity<Staff>().Property(s => s.Phone).HasMaxLength(10);
            modelBuilder.Entity<Staff>().HasOne(s => s.Address).WithOne(a=> a.Staff).HasForeignKey<Staff>(f=> f.AddressId);

            //product table
            


            modelBuilder.Entity<Product>().HasKey(r => r.Id);
            modelBuilder.Entity<Product>().Property(r => r.ProductName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.ShortCode).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.CostPrice).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.SellingPrice).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.BrandName).HasMaxLength(30).IsRequired();

            //category table
            modelBuilder.Entity<Category>().HasKey(r => r.Id);
            modelBuilder.Entity<Category>().Property(r => r.CategoryName).HasMaxLength(30).IsRequired();

            //productcategory table
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.ProductId, pc.CategoryId });

            //Inventory table
            modelBuilder.Entity<Inventory>().HasKey(x => x.Id);
            
            modelBuilder.Entity<Inventory>().Property(x => x.DateOfSupply);
            modelBuilder.Entity<Inventory>().Property(x => x.Quantity).IsRequired();

            //supplier Table
            modelBuilder.Entity<Supplier>().HasKey(x => x.Id);
            modelBuilder.Entity<Supplier>().Property(x => x.FirstName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Supplier>().Property(x => x.LastName).HasMaxLength(30);
            modelBuilder.Entity<Supplier>().Property(x => x.Email).HasMaxLength(50);
            modelBuilder.Entity<Supplier>().Property(x => x.City).HasMaxLength(30);
            modelBuilder.Entity<Supplier>().Property(x => x.Phone).HasMaxLength(10);


            //Purchase Order
            modelBuilder.Entity<PurchaseOrder>().HasKey(x => x.Id);


            modelBuilder.Entity<PurchaseOrder>().Property(x => x.Quantity).IsRequired();
            modelBuilder.Entity<PurchaseOrder>().Property(x => x.OrderDate).IsRequired();
            










        }

    }
}
