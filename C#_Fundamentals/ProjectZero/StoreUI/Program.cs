using System;
using SBL;
using StoreDL;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;


            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = new MainMenu();
            

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                //Clean the screen on the terminal
                //Console.Clear();

                //IMenu interface can hold a bunch of objects as long as they inherited from
                //IMenu, this lets us dynamically change the page by having the page variable
                //Point to a different object each time
                page.Menu();
                MenuType currentPage = page.YourChoice();

                //switch case will change the page variable to point to another object to change
                //its MainMenu 
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        page = new MainMenu();
                        break;
                    case MenuType.ManagerLogin:
                        page = new ManagerLogin(new StoreBL(new Repository()));
                        break;
                    case MenuType.CustomerLogin:
                        page = new CustomerLogin();
                        break;
                    case MenuType.SelectStore:
                        page = new SelectStore(new StoreBL(new Repository()));
                        break;
                    case MenuType.ViewOrderHistory:
                        page = new ViewOrderHistory();
                        break;
                    case MenuType.ManagerMenu:
                        page = new ManagerMenu();
                        break;
                    case MenuType.StorePage:
                        page = new StorePage(new StoreBL(new Repository()));
                        break;
                    case MenuType.SearchCustomer:
                        page = new SearchCustomer(new StoreBL(new Repository()));
                        break;
                    case MenuType.PlaceOrders:
                        page = new PlaceOrders(new StoreBL(new Repository()));
                        break;
                    case MenuType.CustomerMenu:
                        page = new CustomerMenu();
                        break;
                    case MenuType.ReplenishInventory:
                        page = new ReplenishInventory();
                        break;
                    case MenuType.ShowStore:
                        page = new ShowStore(new StoreBL(new Repository()));
                        break;
                    case MenuType.CustomerSign:
                        page = new CustomerSign(new StoreBL(new Repository()));
                        break;
                    case MenuType.AddCustomer:
                        page = new AddCustomer(new StoreBL(new Repository()));
                        break;
                    case MenuType.ViewStoreFrontInventory:
                        page = new ViewStoreFrontInventory(new StoreBL(new Repository()));
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("You forgot to add a menu in your enum/code");
                        repeat = false;
                        break;
                }
            }

        }
    }
}