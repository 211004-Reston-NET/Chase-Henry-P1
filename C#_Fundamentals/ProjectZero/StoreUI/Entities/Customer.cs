using System;
using System.Collections.Generic;

#nullable disable

namespace StoreUI.Entities
{
    public partial class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ListOfOrders { get; set; }
    }
}
