using System;
using System.Collections.Generic;
using SBL;
using StoreModels;

namespace StoreUI
{
    public class SearchCustomer : IMenu
    {
        private IStoreBL _customerBL;
        public SearchCustomer(IStoreBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.Clear();
            List<Customer> listOfCust = _customerBL.GetCustomer(MainMenu._findCustName);
            Console.WriteLine("Search results");
            foreach (Customer cust in listOfCust)
            {
                Console.WriteLine("====================");
                Console.WriteLine(cust);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //case "1":
                    //return MenuType.MainMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.SearchCustomer;
            }
        }
    }
}