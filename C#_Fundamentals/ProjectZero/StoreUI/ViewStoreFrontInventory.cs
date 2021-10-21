using System;
using System.Collections.Generic;
using SBL;
using StoreModels;

namespace StoreUI
{
    public class ViewStoreFrontInventory : IMenu
    {
        private IStoreBL _restBL;
        public ViewStoreFrontInventory(IStoreBL p_restBL)
        {
            _restBL = p_restBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<StoreFront> listOfProducts = _restBL.GetAllProducts();

            foreach (StoreFront place in listOfProducts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(place);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}