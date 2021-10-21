using System;
using System.Collections.Generic;
using SBL;
using StoreModels;

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
        public static string _findStoreName;
        public SelectStore(IStoreBL p_storefrontBL)
        {
            _storefrontBL = p_storefrontBL;
        }
        public void Menu()
        {
             Console.WriteLine("List of Stores");
            List<StoreFront> listOfStoreFronts = _storefrontBL.GetAllStoreFronts();

            foreach (StoreFront place in listOfStoreFronts)
            {
                Console.WriteLine("====================");
                Console.WriteLine(place);
                Console.WriteLine("====================");
            }
            Console.WriteLine("Select Store needs implementation.");
            Console.WriteLine("[2] - Select a Store");
            Console.WriteLine("[1] - Back");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "2":
                    Console.WriteLine("Enter the name of the Store you wish to view.");
                    _findStoreName = Console.ReadLine();
                    return MenuType.ShowStore;
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