using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Models.Customer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer()
        {
            CustomerId = 1;
            Name = "Steven Pham";
            Address = "Viet Nam";
        }
    }
}
