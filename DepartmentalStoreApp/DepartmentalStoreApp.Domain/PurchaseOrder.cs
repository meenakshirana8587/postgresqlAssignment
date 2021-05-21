using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public long Quantity { get; set; }
        public long ProductId { get; set; }
        public Product Products { get; set; }
        
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
