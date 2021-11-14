using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class CustomerMenu : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Menu!");
            Console.WriteLine("Select your store or view your order history.");
            Console.WriteLine("[2] - Select a store");
            Console.WriteLine("[1] - View Order History");
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
                    return MenuType.ViewOrderHistory;
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