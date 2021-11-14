using System;
using SBL;
using StoreModels;

namespace StoreUI
{
    public class CustomerSign : IMenu
    {
        private static Customer _customer = new Customer();
        private IStoreBL _customerBL;
         
        public CustomerSign(IStoreBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Sign-in with your info.");
            Console.WriteLine("Name - " + _customer.Name);
            Console.WriteLine("Address - "+ _customer.Address);
            Console.WriteLine("Email - "+ _customer.Email);
            //Console.WriteLine("Orders - "+ _customer.ListOfOrders);
            Console.WriteLine("[5] - Test Progress");
            Console.WriteLine("[4] - Sign-in");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for Address");
            Console.WriteLine("[1] - Input value for Email");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    return MenuType.CustomerMenu;
                case "4":
                    //Add implementation to talk to the repository method to add a restaurant
                    _customerBL.AddCustomer(_customer);
                    return MenuType.CustomerMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _customer.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the Address");
                    _customer.Address = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the Email");
                    _customer.Email = Console.ReadLine();
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