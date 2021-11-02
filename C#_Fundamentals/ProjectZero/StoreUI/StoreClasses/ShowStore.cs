using System;
using System.Collections.Generic;
using SBL;
using StoreModels;

namespace StoreUI
{
    public class ShowStore : IMenu
    {
        private IStoreBL _storefrontBL;
        public ShowStore(IStoreBL p_storefrontBL)
        {
            this._storefrontBL = p_storefrontBL;
        }
        public void Menu()
        {
            // Console.Clear();
            // List<StoreFront> listOfFront = _storefrontBL.GetStoreFront(SelectStore._findStoreName.Name);
            // Console.WriteLine("Search results");
            // foreach (StoreFront front in listOfFront)
            // {
            //     Console.WriteLine("====================");
            //     Console.WriteLine(front);
            //     Console.WriteLine("====================");
            // }
            // Console.WriteLine("[2] - Proceed to Store Page");
            // Console.WriteLine("[1] - Back");
            // Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "2":
                    return MenuType.StorePage;
                case "1":
                    return MenuType.SelectStore;
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