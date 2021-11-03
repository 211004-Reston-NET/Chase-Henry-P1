using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public Order()
        {
            LineItems = new HashSet<LineItem>();
            StoreFronts = new HashSet<StoreFront>();
        }

        public int OrderId { get; set; }
        public int? Total { get; set; }
        public int? CustId { get; set; }
        public int? StoreId { get; set; }
        public int? prodId {get; set;}

        public virtual Customer Cust { get; set; }
        public virtual StoreFront Store { get; set; }
        public virtual Product prod {get; set;}
        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<StoreFront> StoreFronts { get; set; }
        //public virtual ICollection<Product> Products {get; set;}
    }
}
