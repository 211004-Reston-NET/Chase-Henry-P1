using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {
        public static string _findCustName;
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Store Manager App!");
            Console.WriteLine("What would you like to do?");
            //Console.WriteLine("[2] - Manager Sign-in");
            Console.WriteLine("[5] - View Store Front Inventory");
            Console.WriteLine("[4] - View Order History");
            Console.WriteLine("[3] - Place Order for Customer");
            Console.WriteLine("[2] - Search Customer");
            Console.WriteLine("[1] - Add Customer");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    return MenuType.SelectStore;
                case "4":
                    return MenuType.ViewOrderHistory;
                case "3":
                    return MenuType.PlaceOrders;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter the name of the customer you want to find.");
                    _findCustName = Console.ReadLine();
                    return MenuType.SearchCustomer;
                case "1":
                    return MenuType.AddCustomer;
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