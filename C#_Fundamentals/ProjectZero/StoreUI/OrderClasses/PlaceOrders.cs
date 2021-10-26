using System;
using SBL;
using StoreModels;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class PlaceOrders : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        private static Orders _orders = new Orders();
        private IStoreBL _ordersBL;
         
        public PlaceOrders(IStoreBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Enter Order Information");
            Console.WriteLine("List of Items - " + _orders.ListOfLineItems);
            Console.WriteLine("Store Address - "+ _orders.StoreFrontAddress);
            Console.WriteLine("Order Total - "+ _orders.Total);
            //Console.WriteLine("Orders - "+ _customer.ListOfOrders);
            //Console.WriteLine("[5] - Test Progress");
            Console.WriteLine("[4] - Submit Order");
            Console.WriteLine("[3] - Input List of Items");
            Console.WriteLine("[2] - Input value for Store Address");
            Console.WriteLine("[1] - Input value for Total Price");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                // case "5":
                //      return MenuType.CustomerSign;
                case "4":
                    _ordersBL.PlaceOrders(_orders);
                    return MenuType.StorePage;
                case "3":
                    Console.WriteLine("Type in the List of items to order.");
                    _orders.ListOfLineItems = Console.ReadLine();
                    return MenuType.PlaceOrders;
                case "2":
                    Console.WriteLine("Type in the Store Front Address.");
                    _orders.StoreFrontAddress = Console.ReadLine();
                    return MenuType.PlaceOrders;
                case "1":
                    Console.WriteLine("Type in the Total Price.");
                    _orders.Total = Console.ReadLine();
                    return MenuType.PlaceOrders;
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