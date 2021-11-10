using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class StoreFrontVM
    {
        public StoreFrontVM()
        {

        }
        public StoreFrontVM(StoreFront p_store)
        {
            this.Name = p_store.Name;
            this.Address = p_store.Address;
            this.StoreId = p_store.StoreId;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? StoreId { get; set; }
    }
}
