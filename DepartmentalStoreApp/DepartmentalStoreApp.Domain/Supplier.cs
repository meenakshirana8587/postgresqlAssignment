using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Supplier
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Inventory Inventory { get; set; }

        //public PurchaseOrder PurchaseOrder { get; set; }
    }
}
