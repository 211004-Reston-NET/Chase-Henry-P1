using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using SBL;
using System.ComponentModel.DataAnnotations;

namespace StoreWebUI.Models
{
    public class CustomerVM
    {
        public CustomerVM()
        {

        }
        public CustomerVM(Customer p_cust)
        {
            this.CustId = p_cust.CustId;
            this.Name = p_cust.Name;
            this.Address = p_cust.Address;
            this.Email = p_cust.Email;
        }
        public int CustId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
