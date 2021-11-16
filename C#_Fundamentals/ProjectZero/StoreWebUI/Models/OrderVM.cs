using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public int? Total { get; set; }
        [Required]
        public int? CustId { get; set; }
        [Required]
        public int? StoreId { get; set; }
        [Required]
        public int? prodId { get; set; }
    }
}
