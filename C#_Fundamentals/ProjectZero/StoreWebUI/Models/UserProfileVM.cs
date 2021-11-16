using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreWebUI.Models
{
    public class UserProfileVM
    {
        public UserProfileVM()
        {

        }
        public UserProfileVM(UserProfile p_ord)
        {
            this.UserId= p_ord.UserId;
            this.UserName = p_ord.UserName;
            this.Password = p_ord.Password;
            this.IsActive = p_ord.IsActive;
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsActive { get; set; }
    }
}
