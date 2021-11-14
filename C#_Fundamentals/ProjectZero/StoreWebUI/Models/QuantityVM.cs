using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class QuantityVM
    {

        public QuantityVM()
        {

        }
        public QuantityVM(QuantityModel p_prod)
        {
            this.ProdId = p_prod.ProdId;
            this.Name = p_prod.Name;
            this.Price = p_prod.Price;
            this.StoreId = p_prod.StoreId;
            this.ItemId = p_prod.ItemId;
            this.Quantity = p_prod.Quantity;
        }

        public int ProdId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? StoreId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
    }
}
