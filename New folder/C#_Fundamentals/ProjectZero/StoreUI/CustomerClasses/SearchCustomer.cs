using System;
using System.Collections.Generic;
using SBL;
using StoreModels;
using Serilog;

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
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/SearchCustomer.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            
            Console.Clear();
            List<Customer> listOfCust = _customerBL.GetCustomer(MainMenu._findCustName);
            Console.WriteLine("Search results");
            if (listOfCust.Count == 0) {
                    Console.WriteLine("Not a valid Customer Name");
                    Log.Information("Invalid Customer Name Provided");
                }
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