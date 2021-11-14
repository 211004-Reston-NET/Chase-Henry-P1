using System;
using System.Collections.Generic;
using SBL;
using StoreModels;
using Microsoft.Data.SqlClient;
using Serilog;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class StoreOrders : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        private IStoreBL _ordersBL;
        public static Orders _findStoreOrders = new Orders();
        public StoreOrders(IStoreBL p_ordersBL)
        {
            _ordersBL = p_ordersBL;
        }
        public void Menu()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/ViewStoreOrders.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            int result = Int32.Parse(ViewOrderHistory._findStoreName);
            //Console.Clear();
            Console.WriteLine("List of Store Orders");
            List<Orders> listOfCust = _ordersBL.GetAllStoreOrdersById(result);
            Console.WriteLine("Search results");
            if (listOfCust.Count == 0) {
                    Console.WriteLine("Not a valid Store ID");
                    Log.Information("Invalid Store ID in View Store Orders");
                }
            foreach (Orders cust in listOfCust)
            {
                Console.WriteLine("====================");
                Console.WriteLine(cust);
                if (cust == null) {
                    Console.WriteLine("Not a valid Store ID");
                    //Console.ReadLine();
                }
                Console.WriteLine("====================");
            }
            //  try {
            // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //     builder.DataSource = "211004-server.database.windows.net"; 
            //     builder.UserID = "chaseh";            
            //     builder.Password = "Motox523!";     
            //     builder.InitialCatalog = "RR-Project0";

            // using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            //     {
            //        //Console.WriteLine("Store Orders");
            //         Console.WriteLine("=====================");

            //         String sql = "select * FROM Orders o where o.storeId = 1";

            //         using (SqlCommand command = new SqlCommand(sql, connection))
            //         {
            //             connection.Open();
            //             using (SqlDataReader reader = command.ExecuteReader())
            //             {
            //                 while (reader.Read())
            //                 {
            //                     Console.WriteLine(" Order ID: {0}\n Total: {1}\n Customer ID: {2}\n Store ID: {3}\n =====================", reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
            //                 }
            //             }
            //         }
            //         //Console.WriteLine("=====================");                   
            //     }
            //     }
            //     catch (SqlException e)
            // {
            //     Console.WriteLine(e.ToString());
            // }
            Console.WriteLine("[0] - Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.ViewOrderHistory;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}