using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Role
    {
        public long Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public List<Staff> Staff { get; set; }
    }
}
