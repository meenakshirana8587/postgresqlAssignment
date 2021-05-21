using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class ProductSupplier
    {
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }

    }
}
