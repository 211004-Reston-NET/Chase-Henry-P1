using System;
using System.Collections.Generic;
using SBL;
using StoreModels;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class StorePage : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        private IStoreBL _storefrontBL;
        public StorePage(IStoreBL p_storefrontBL)
        {
            _storefrontBL = p_storefrontBL;
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Store Page");
            Console.WriteLine("[3] - Place Order");
            Console.WriteLine("[2] - Replenish Inventory");
            Console.WriteLine("[1] - Back");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "3":
                    return MenuType.PlaceOrders;
                case "2":
                    return MenuType.ReplenishInventory;
                case "1":
                    return MenuType.MainMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}