using System;
using SBL;
using StoreModels;
using Serilog;
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
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/PlaceOrders.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            
            Console.Clear();
            Console.WriteLine("Enter Order Information");
            Console.WriteLine("Customer ID - " + _orders.CustId);
            Console.WriteLine("Store ID - "+ _orders.StoreId);
            Console.WriteLine("Product ID - "+ _orders.prodId);
            Console.WriteLine("Order Total - "+ _orders.Total);
            //Console.WriteLine("Orders - "+ _customer.ListOfOrders);
            
            Console.WriteLine("[5] - Submit Order");
            Console.WriteLine("[4] - Input Customer ID");
            Console.WriteLine("[3] - Input Store ID");
            Console.WriteLine("[2] - Input Product ID");
            Console.WriteLine("[1] - Input Total Price");
            Console.WriteLine("[0] - Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                     if (_orders.CustId == null || _orders.StoreId == null || _orders.prodId == null || _orders.Total == null){
                        Console.WriteLine("Order Cannot Have Null Values!");
                        Log.Information("Null Value Attempted in Place Orders");
                        Console.ReadLine();
                        return MenuType.MainMenu;
                     } else {
                         _ordersBL.PlaceOrders(_orders);
                     }
                    return MenuType.MainMenu;
                case "4":
                    Console.WriteLine("Type in the List of items to order.");
                    // int xd;
                    // string dx;
                    // dx = Console.ReadLine();
                    // xd = Convert.ToInt32(dx);
                    
                    _orders.CustId = int.Parse(Console.ReadLine());
                    return MenuType.PlaceOrders;
                case "3":
                    Console.WriteLine("Type in the Store Front ID.");
                    // int val;
                    // string res;
                    // res = Console.ReadLine();
                    // val = Convert.ToInt32(res);
                    _orders.StoreId = int.Parse(Console.ReadLine());
                    return MenuType.PlaceOrders;
                case "2":
                    Console.WriteLine("Type in the Product ID.");
                    // int val;
                    // string res;
                    // res = Console.ReadLine();
                    // val = Convert.ToInt32(res);
                    _orders.prodId = int.Parse(Console.ReadLine());
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