using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SBL;
using StoreDL;

namespace StoreUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our RRUI
                .Build(); //Builds our configuration

             DbContextOptions<RRProject0Context> options = new DbContextOptionsBuilder<RRProject0Context>()
                 .UseSqlServer(configuration.GetConnectionString("ReferenceDB"))
                 .Options;

            switch (p_menu)
                {
                    case MenuType.MainMenu:
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        return new MainMenu();
                    case MenuType.ManagerLogin:
                        return new ManagerLogin(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.CustomerLogin:
                        return new CustomerLogin();
                    case MenuType.SelectStore:
                        return new SelectStore(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.ViewOrderHistory:
                        return new ViewOrderHistory();
                    case MenuType.ManagerMenu:
                        return new ManagerMenu();
                    case MenuType.StorePage:
                        return new StorePage(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.StorePage1:
                        return new StorePage1(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.StorePage2:
                        return new StorePage2(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.SearchCustomer:
                        return new SearchCustomer(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.PlaceOrders:
                        return new PlaceOrders(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.CustomerMenu:
                        return new CustomerMenu();
                    case MenuType.ReplenishInventory:
                        return new ReplenishInventory();
                    case MenuType.ShowStore:
                        return new ShowStore(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.CustomerSign:
                        return new CustomerSign(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.AddCustomer:
                        return new AddCustomer(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.ViewStoreFrontInventory:
                        return new ViewStoreFrontInventory(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.CustomerOrders:
                        return new CustomerOrders(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.StoreOrders:
                        return new StoreOrders(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.StoreOrders1:
                        return new StoreOrders1(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    case MenuType.StoreOrders2:
                        return new StoreOrders2(new StoreBL(new RepositoryCloud(new RRProject0Context(options))));
                    default:
                        return null;
                }
            }
    }
}