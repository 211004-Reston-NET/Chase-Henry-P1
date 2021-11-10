using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class ProductVM
    {
        public ProductVM()
        {

        }
        public ProductVM(Products p_prod)
        {
            this.ProdId = p_prod.ProdId;
            this.Name = p_prod.Name;
            this.Price = p_prod.Price;
            this.StoreId = p_prod.StoreId;
        }
        public int ProdId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? StoreId { get; set; }
    }
}
