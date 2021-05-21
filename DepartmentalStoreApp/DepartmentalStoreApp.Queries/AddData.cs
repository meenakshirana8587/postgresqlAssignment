using DepartmentalStoreApp.Data;
using DepartmentalStoreApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Queries
{
    public class AddData
    {
        public static DepartmentalStoreContext context = new DepartmentalStoreContext();
        public static void InsertIntoRole()
        {
            var role1 = new Role { Id = 3, RoleName = "Cashier", Description = "Does the billing" };
            var role2 = new Role { Id = 4, RoleName = "Inventory Operator", Description = "manages the inventory" };
            context.AddRange(role1, role2);

            context.SaveChanges();
        }

        public static void InsertIntoAddress()
        {
            var addr1 = new Address { AddressLine1 = "pink street", City = "New Delhi", State = "Delhi", PinCode = "11223344" };
            var addr2 = new Address { AddressLine1 = "blue street", City = "karnataka", State = "Banagalore", PinCode = "22334455" };
            var addr3 = new Address { AddressLine1 = "plain street", City = "Mumbai", State = "Maharashtra", PinCode = "33445566" };
            var addr4 = new Address { AddressLine1 = "hill street", City = "Ahemdabad", State = "Gujarat", PinCode = "44556677" };
            var addr5 = new Address { AddressLine1 = "jason street", City = "New Delhi", State = "Delhi", PinCode = "11223344" };
            var addr6 = new Address { AddressLine1 = "green street", City = "New Delhi", State = "Delhi", PinCode = "11223344" };
            context.AddRange(addr1, addr2, addr3, addr4, addr5, addr6);
            context.SaveChanges();
        }

        public static void InsertIntoStaff()
        {
            var staff1 = new Staff { Firstname = "Saumya", LastName = "Singhania", Gender = 'F', DateOfBirth = new DateTime(1995 - 12 - 23), Phone = "1234567890", Salary = 224243, AddressId = 1, RoleId = 1 };
            var staff2 = new Staff { Firstname = "Rohit", LastName = "Pandey", Gender = 'M', DateOfBirth = new DateTime(1994 - 11 - 22), Phone = "9087654321", Salary = 123456, AddressId = 2, RoleId = 2 };
            var staff3 = new Staff { Firstname = "Harshit", LastName = "Verma", Gender = 'M', DateOfBirth = new DateTime(1995 - 10 - 21), Phone = "1432567890", Salary = 113456, AddressId = 3, RoleId = 3 };
            var staff4 = new Staff { Firstname = "Yanshik", LastName = "Rai", Gender = 'M', DateOfBirth = new DateTime(1993 - 9 - 20), Phone = "9012345678", Salary = 113456, AddressId = 4, RoleId = 3 };
            var staff5 = new Staff { Firstname = "Ajay", LastName = "Pandey", Gender = 'M', DateOfBirth = new DateTime(1992 - 8 - 19), Phone = "8907654321", Salary = 133456, AddressId = 5, RoleId = 4 };
            var staff6 = new Staff { Firstname = "Aarushi", LastName = "Raizada", Gender = 'F', DateOfBirth = new DateTime(1991 - 7 - 18), Phone = "3098765421", Salary = 133456, AddressId = 6, RoleId = 4 };
            context.AddRange(staff1, staff2, staff3, staff4, staff5, staff6);
            context.SaveChanges();

        }


        public static void InsertIntoProduct()
        {
            var prod1 = new Product { ProductName = "Pen", BrandName = " Reynolds", ShortCode = "pn", CostPrice = 25.00M, SellingPrice = 30.00M };
            var prod2 = new Product { ProductName = "Eraser", BrandName = " Apsara", ShortCode = "er", CostPrice = 20.00M, SellingPrice = 35.00M };
            var prod3 = new Product { ProductName = "Jeans", BrandName = " Pantaloons", ShortCode = "jn", CostPrice = 2500.00M, SellingPrice = 3000.00M };
            var prod4 = new Product { ProductName = "Shirt", BrandName = " Zara", ShortCode = "sh", CostPrice = 2000.00M, SellingPrice = 2500.00M };
            var prod5 = new Product { ProductName = "Dairy milk Chocholate", BrandName = " Dairy Milk", ShortCode = "dmch", CostPrice = 100.00M, SellingPrice = 150.00M };
            var prod6 = new Product { ProductName = "Stawberry", BrandName = " Fresh Farms", ShortCode = "st", CostPrice = 1500.00M, SellingPrice = 2000.00M };
            context.AddRange(prod1, prod2, prod3, prod4, prod5, prod6);
            context.SaveChanges();
        }


        public static void InsertIntoCategory()
        {
            var cat1 = new Category { CategoryName = "Stationary" };
            var cat2 = new Category { CategoryName = "Lifestyle" };
            var cat3 = new Category { CategoryName = "Fasion" };
            var cat4 = new Category { CategoryName = "Food" };
            var cat5 = new Category { CategoryName = "Perishables" };
            context.AddRange(cat1, cat2, cat3, cat4, cat5);
            context.SaveChanges();

        }


        public static void InsertIntoProductCategory()
        {
            var pc1 = new ProductCategory { ProductId = 1, CategoryId = 1 };
            var pc2 = new ProductCategory { ProductId = 2, CategoryId = 1 };
            var pc3 = new ProductCategory { ProductId = 3, CategoryId = 2 };
            var pc4 = new ProductCategory { ProductId = 3, CategoryId = 3 };
            var pc5 = new ProductCategory { ProductId = 4, CategoryId = 2 };
            var pc6 = new ProductCategory { ProductId = 4, CategoryId = 3 };
            var pc7 = new ProductCategory { ProductId = 5, CategoryId = 4 };
            var pc8 = new ProductCategory { ProductId = 6, CategoryId = 4 };
            var pc9 = new ProductCategory { ProductId = 6, CategoryId = 5 };
            context.AddRange(pc1, pc2, pc3, pc4, pc5, pc6, pc7, pc8, pc9);
            context.SaveChanges();
        }


        public static void InsertIntoInventory()
        {
            var inv1 = new Inventory { ProductId = 1, DateOfSupply = new DateTime(2020 - 12 - 23), SupplierId = 1, Quantity = 30 };
            var inv2 = new Inventory { ProductId = 2, DateOfSupply = new DateTime(2020 - 11 - 23), SupplierId = 2, Quantity = 20 };
            var inv3 = new Inventory { ProductId = 3, DateOfSupply = new DateTime(2019 - 10 - 23), SupplierId = 3, Quantity = 200 };
            var inv4 = new Inventory { ProductId = 4, DateOfSupply = new DateTime(2021 - 02 - 23), SupplierId = 1, Quantity = 40 };
            var inv5 = new Inventory { ProductId = 5, DateOfSupply = new DateTime(2021 - 03 - 23), SupplierId = 2, Quantity = 15 };
            var inv6 = new Inventory { ProductId = 6, DateOfSupply = new DateTime(2019 - 12 - 23), SupplierId = 3, Quantity = 60 };
            context.AddRange(inv1, inv2, inv3, inv4, inv5, inv6);
            context.SaveChanges();

        }


        public static void InsertIntoSupplier()
        {
            var supplier1 = new Supplier { FirstName = "Raj", LastName = "Jaiswal", City = "New Delhi", Email = "rj@mail.com", Phone = "1234567451" };
            var supplier2 = new Supplier { FirstName = "Rani", LastName = "Roy", City = "New Jersey", Email = "rr@mail.com", Phone = "1234567450" };
            var supplier3 = new Supplier { FirstName = "Abhishek", LastName = "Ambani", City = "Mumbai", Email = "aa@mail.com", Phone = "1234567400" };
            context.AddRange(supplier1, supplier2, supplier3);
            context.SaveChanges();

        }


        public static void InsertIntoPurchaseOrder()
        {
            var po1 = new PurchaseOrder { ProductId = 1, OrderDate = new DateTime(2020 - 12 - 23), Quantity = 200, SupplierId = 1 };
            var po2 = new PurchaseOrder { ProductId = 3, OrderDate = new DateTime(2021 - 2 - 23), Quantity = 20, SupplierId = 3 };
            var po3 = new PurchaseOrder { ProductId = 6, OrderDate = new DateTime(2020 - 11 - 23), Quantity = 2, SupplierId = 2};
            context.AddRange(po1, po2, po3);
            context.SaveChanges();

        }
    }
}
