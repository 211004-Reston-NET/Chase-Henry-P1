using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class ViewOrderHistory : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public static string _findCustName;
        public static string _findStoreName;
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Select Which Orders to View");
            Console.WriteLine("[2] - View Store Orders");
            Console.WriteLine("[1] - View Customer Orders");
            Console.WriteLine("[0] - Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "2":
                    Console.WriteLine("Enter the Store ID");
                    _findStoreName = Console.ReadLine();
                    return MenuType.StoreOrders;
                case "1":
                    Console.WriteLine("Enter the ID of the customer you want to find.");
                    _findCustName = Console.ReadLine();
                    return MenuType.CustomerOrders;
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