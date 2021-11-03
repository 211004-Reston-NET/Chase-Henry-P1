using System;
using System.Collections.Generic;
using SBL;
using StoreModels;
using Microsoft.Data.SqlClient;
using Serilog;


namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class SelectStore : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        private IStoreBL _storefrontBL;
        public string _findStoreName = new string("");
        public SelectStore(IStoreBL p_storefrontBL)
        {
            _storefrontBL = p_storefrontBL;
        }
        public void Menu()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/SelectStoreInventory.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            //Console.Clear();
            Console.WriteLine("List of Stores");
            List<StoreFront> listOfStoreFronts = _storefrontBL.GetAllStoreFronts();
            foreach (StoreFront place in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(place);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Enter a Store ID to view its Inventory");
            Console.WriteLine("[0] - Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter the Store ID");
                    _findStoreName = Console.ReadLine();
                     if (_findStoreName == "1"){
                         return MenuType.StorePage;
                     }
                     else if (_findStoreName == "2") {
                        return MenuType.StorePage1;
                     }
                     else if (_findStoreName == "3") {
                         return MenuType.StorePage2;
                     }
                     else {
                         Log.Information("Invalid Store ID Given In Select Store Inventory");
                         Console.WriteLine("Not a Valid Store ID");
                         Console.WriteLine("Press Enter to continue");
                         Console.ReadLine();
                         return MenuType.SelectStore;
                     }
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