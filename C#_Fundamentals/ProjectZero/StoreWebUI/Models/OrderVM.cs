using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class OrderVM
    {
        public OrderVM()
        {

        }
        public OrderVM(Orders p_ord)
        {
            this.OrderId = p_ord.OrderId;
            this.Total = p_ord.Total;
            this.CustId = p_ord.CustId;
            this.StoreId = p_ord.StoreId;
            this.prodId = p_ord.prodId;
        }
        public int OrderId { get; set; }
        public int? Total { get; set; }
        public int? CustId { get; set; }
        public int? StoreId { get; set; }
        public int? prodId { get; set; }
    }
}
