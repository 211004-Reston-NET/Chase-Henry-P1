using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreFront
    {
        public StoreFront()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
