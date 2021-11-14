using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class LineItemVM
    {
        public LineItemVM()
        {

        }
        public LineItemVM(LineItems p_li)
        {
            this.ItemId = p_li.ItemId;
            this.Quantity = p_li.Quantity;
        }
        public int ItemId { get; set; }
        public int? Quantity { get; set; }
    }
}
