using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Inventory
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfSupply { get; set; }
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
