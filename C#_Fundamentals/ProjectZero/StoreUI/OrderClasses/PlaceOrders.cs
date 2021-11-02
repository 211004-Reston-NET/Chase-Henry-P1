using System;
using SBL;
using StoreModels;
//using StoreDL;

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
            Console.WriteLine("Customer ID - " + _orders.CustId);
            Console.WriteLine("Store ID - "+ _orders.StoreId);
            Console.WriteLine("Product ID - "+ _orders.prodId);
            Console.WriteLine("Order Total - "+ _orders.Total);
            //Console.WriteLine("Orders - "+ _customer.ListOfOrders);
            //Console.WriteLine("[5] - Test Progress");
            Console.WriteLine("[4] - Submit Order");
            Console.WriteLine("[3] - Input Customer ID");
            Console.WriteLine("[2] - Input Store ID");
            Console.WriteLine("[1] - Input Total Price");
            Console.WriteLine("[0] - Back");
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
                    return MenuType.MainMenu;
                case "3":
                    Console.WriteLine("Type in the List of items to order.");
                    // int xd;
                    // string dx;
                    // dx = Console.ReadLine();
                    // xd = Convert.ToInt32(dx);
                    
                    _orders.CustId = int.Parse(Console.ReadLine());
                    return MenuType.PlaceOrders;
                case "2":
                    Console.WriteLine("Type in the Store Front Address.");
                    // int val;
                    // string res;
                    // res = Console.ReadLine();
                    // val = Convert.ToInt32(res);
                    _orders.StoreId = int.Parse(Console.ReadLine());
                    return MenuType.PlaceOrders;
                case "1":
                    Console.WriteLine("Type in the Total Price.");
                    _orders.Total = int.Parse(Console.ReadLine());
                    return MenuType.PlaceOrders;
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