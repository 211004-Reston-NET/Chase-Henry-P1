using System;
using System.Collections.Generic;
using SBL;
using StoreModels;
using Microsoft.Data.SqlClient;
using Serilog;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class CustomerOrders : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public static Orders _findCustomerOrders = new Orders();
        private IStoreBL _customerBL;
        public CustomerOrders(IStoreBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/ViewCustomerOrders.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            int result = Int32.Parse(ViewOrderHistory._findCustName);
            //Console.Clear();
            Console.WriteLine("List of Customer Orders");
            List<Orders> listOfCust = _customerBL.GetCustomerOrders(result);
            Console.WriteLine("Search results");
            if (listOfCust.Count == 0) {
                    Console.WriteLine("Not a valid Customer ID");
                    Log.Information("Invalid Customer ID in View Customer Orders");
                }
            foreach (Orders cust in listOfCust)
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
                case "0":
                    return MenuType.ViewOrderHistory;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}