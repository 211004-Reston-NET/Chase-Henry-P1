using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            Products = new HashSet<Product>();
        }

        public int ItemId { get; set; }
        public string Product { get; set; }
        public int? Quantity { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
