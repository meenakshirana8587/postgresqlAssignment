using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreApp.Domain
{
    public class Staff
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public long AddressId { get; set; }
        public long RoleId { get; set; }
        public long Salary { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }
}
