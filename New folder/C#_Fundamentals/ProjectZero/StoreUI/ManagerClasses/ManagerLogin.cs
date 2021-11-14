using System;
using SBL;
using StoreModels;

namespace StoreUI
{
    public class ManagerLogin : IMenu
    {
        private static Customer _customer = new Customer();
        private IStoreBL _customerBL;
         
        public ManagerLogin(IStoreBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Sign-in with your manager info.");
            Console.WriteLine("Name - " + _customer.Name);
            Console.WriteLine("Address - "+ _customer.Address);
            Console.WriteLine("[5] - Test Progress");
            Console.WriteLine("[4] - Sign-in");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for password");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    return MenuType.ManagerMenu;
                case "3":
                    //Add implementation to talk to the repository method to add a restaurant
                    _customerBL.AddCustomer(_customer);
                    return MenuType.StoreMenu;
                case "2":
                    Console.WriteLine("Type in the value for the Name");
                    _customer.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the password");
                    _customer.Address = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}