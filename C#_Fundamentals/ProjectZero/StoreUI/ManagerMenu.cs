using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class ManagerMenu : IMenu
    {
        public static string _findCustName;
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.WriteLine("Welcome to the Manager Menu!");
            Console.WriteLine("Select your store or search for a customer.");
            Console.WriteLine("[2] - View Stores");
            Console.WriteLine("[1] - Search Customer");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "2":
                    return MenuType.SelectStore;
                case "1":
                    Console.WriteLine("Enter the name of the customer you want to find.");
                    _findCustName = Console.ReadLine();
                    return MenuType.SearchCustomer;
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