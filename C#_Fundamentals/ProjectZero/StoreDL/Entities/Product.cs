using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? ItemId { get; set; }
        public int? StoreId { get; set; }

        public virtual LineItem Item { get; set; }
        public virtual StoreFront Store { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders {get; set;}
    }
}
