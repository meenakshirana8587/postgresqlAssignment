using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Product
    {

        public Product()
        {
            ProductCategories = new List<ProductCategory>();
        }
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string ShortCode { get; set; }
        
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

        
    }
}
