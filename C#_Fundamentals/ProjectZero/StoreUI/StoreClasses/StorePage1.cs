using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SBL;
using StoreModels;
using System.IO;
using Microsoft.EntityFrameworkCore;
using StoreDL.Entities;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class StorePage1 : IMenu
    {
        /*
            Since MainMenu has inherited IMenu, it will have all the methods we have created
            in IMenu.
            This is an example of Inheritance, one of the Object Oriented Pillars
        */
        private IStoreBL _storefrontBL;
        public StorePage1(IStoreBL p_storefrontBL)
        {
            _storefrontBL = p_storefrontBL;
        }
        public void Menu()
        {
            try {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "211004-server.database.windows.net"; 
                builder.UserID = "chaseh";            
                builder.Password = "Motox523!";     
                builder.InitialCatalog = "RR-Project0";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                   Console.WriteLine("Store Page");
                    Console.WriteLine("=====================");

                    String sql = "select p.Name, p.Price, li.itemId, li.Quantity FROM Products p inner join LineItems li on p.itemId = li.itemId where p.storeId = 2";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("Product: {0} Price: {1} Item ID: {2} Quantity: {3}", reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                            }
                        }
                    }
                    Console.WriteLine("=====================");                   
                }
                }
                catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            // List<Products> listOfProducts = _storefrontBL.GetAllProducts();
           
            // Console.WriteLine("Store Page");
            // foreach (Products place in listOfProducts)
            // {
            //     Console.WriteLine("====================");
            //     Console.WriteLine(place);
            //     Console.WriteLine("Quantity: "+quantity);
            //     Console.WriteLine("====================");
            // }
            //Console.Clear();
            
            //Console.WriteLine("[3] - Place Order");
            Console.WriteLine("[4] - Replenish TVs");
            Console.WriteLine("[3] - Replenish Computers");
            Console.WriteLine("[2] - Replenish Fridges");
            Console.WriteLine("[1] - Back");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    try {
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                        builder.DataSource = "211004-server.database.windows.net"; 
                        builder.UserID = "chaseh";            
                        builder.Password = "Motox523!";     
                        builder.InitialCatalog = "RR-Project0";
                        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                        {
                            String sql = "update LineItems Set Quantity = Quantity + 1 where itemId = 4";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                     Console.WriteLine(reader.GetInt32(0));
                                    }
                                }
                            }                 
                        }
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return MenuType.StorePage1;
                case "3":
                    try {
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                        builder.DataSource = "211004-server.database.windows.net"; 
                        builder.UserID = "chaseh";            
                        builder.Password = "Motox523!";     
                        builder.InitialCatalog = "RR-Project0";
                        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                        {
                            String sql = "update LineItems Set Quantity = Quantity + 1 where itemId = 5";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                     Console.WriteLine(reader.GetInt32(0));
                                    }
                                }
                            }                 
                        }
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return MenuType.StorePage1;
                case "2":
                    try {
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                        builder.DataSource = "211004-server.database.windows.net"; 
                        builder.UserID = "chaseh";            
                        builder.Password = "Motox523!";     
                        builder.InitialCatalog = "RR-Project0";
                        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                        {
                            String sql = "update LineItems Set Quantity = Quantity + 1 where itemId = 6";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                     Console.WriteLine(reader.GetInt32(0));
                                    }
                                }
                            }                 
                        }
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return MenuType.StorePage1;
                case "1":
                    return MenuType.SelectStore;
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