using DepartmentalStoreApp.Data;
using DepartmentalStoreApp.Domain;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DepartmentalStoreApp.Queries
{
    public class DepartmentalStoreQueries
    {
        public DepartmentalStoreContext context = new DepartmentalStoreContext();
        public void SelectFromStaff()
        {
            
            var staffdatabyphoneorname = context.Staff.Where(s => s.Phone == "1234567890"|| s.Firstname=="Ajay").ToList();
            
            Console.WriteLine("select from staff by phone number or name");
            Console.WriteLine("******************************************");
            staffdatabyphoneorname.ForEach(p =>Console.WriteLine( p.Firstname+ " "+ p.LastName+" " + p.RoleId ));

            Console.WriteLine();


            var staffbyrole = context.Staff.Where(s => s.RoleId == 3).ToList();
            Console.WriteLine("select from staff by role");
            Console.WriteLine("*************************");

            staffbyrole.ForEach(p => Console.WriteLine(p.Firstname + " " + p.LastName + " " + p.RoleId + " " + p.Phone));
            Console.WriteLine();

        }

        public void SelectFromProduct()
        {
            var productbyname = context.Product.Where(p => p.ProductName == "Jeans").ToList();
            Console.WriteLine("select from product by name");
            Console.WriteLine("****************************");
            productbyname.ForEach(p => Console.WriteLine(p.ProductName + " " +   p.SellingPrice+ " INR"));
            Console.WriteLine();

            var productbysellingprice = context.Product.Where(p => p.SellingPrice > 25.00M && p.SellingPrice < 1000.00M).ToList();
            Console.WriteLine("select from product sp less than or greater than");
            Console.WriteLine("************************************************");
            productbysellingprice.ForEach(p => Console.WriteLine(p.ProductName + " " + p.SellingPrice + " INR"));
            Console.WriteLine();

            var productbycategory = from p in context.Product
                                    join pc in context.ProductCategory on p.Id equals pc.ProductId
                                    join cat in context.Category on pc.CategoryId equals cat.Id
                                    where cat.CategoryName.Contains("Stationary")
                                    select new { p, cat };
                                    
                                    



            foreach (var val in productbycategory)
            {
                Console.WriteLine("Product Name: {0} \t Category Name: {1}", val.p.ProductName, val.cat.CategoryName);
            }
        }
        public  void NumberofProductswithinacategory()
        {
            var result = (from p in context.Category
                          join c in context.ProductCategory
                          on p.Id equals c.CategoryId
                          group p by c.CategoryId into x
                          select new
                          {
                              Count = x.Count<Category>(),
                              Category_Id = x.Key
                          }).ToList();
            Console.WriteLine("count the products in each catagory");

            foreach (var i in result)
            {
                Console.WriteLine("Category_ID : " + i.Category_Id);
                Console.WriteLine("Count : " + i.Count);
            }

        }


        public  void Listsupplier()
        {
            Console.WriteLine("select from supplier by name");
            Console.WriteLine("****************************");

            var suppliernamefilter = context.Supplier.Where(s => s.FirstName.Contains("Raj")).ToList();
            Console.WriteLine(" Id\t name\t phone \t email\t  city");
            foreach (var supplier in suppliernamefilter)
            {
                Console.WriteLine("\t" + supplier.Id + "\t" + supplier.FirstName + "\t" + supplier.Phone + "\t"
                     + supplier.Email + "\t" + supplier.City);
            }
            Console.WriteLine();

            Console.WriteLine("select from supplier by phone");
            Console.WriteLine("*****************************");

            var supplierPhonefilter = context.Supplier.Where(s => s.Phone == "1234567400").ToList();
            Console.WriteLine(" Id\t name\t phone \t email\t  city");
            foreach (var supplier in supplierPhonefilter)
            {
                Console.WriteLine("\t" + supplier.Id + "\t" + supplier.FirstName + "\t" + supplier.Phone + "\t"
                     + supplier.Email + "\t" + supplier.City);
            }
            Console.WriteLine();


            


            
        }



    }
}
