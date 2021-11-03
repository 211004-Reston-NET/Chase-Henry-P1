using System;
using Microsoft.Extensions.Configuration;
using SBL;
using StoreDL;
using Serilog;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("App Started");
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;

            IFactory factory = new MenuFactory();
            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = factory.GetMenu(MenuType.MainMenu);

            // var configuration = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsetting.json")
            //     .Build();
            

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                Console.Clear();
                //Clean the screen on the terminal

                //IMenu interface can hold a bunch of objects as long as they inherited from
                //IMenu, this lets us dynamically change the page by having the page variable
                //Point to a different object each time
                page.Menu();
                MenuType currentPage = page.YourChoice();

                //switch case will change the page variable to point to another object to change
                //its MainMenu 
               if (currentPage == MenuType.Exit)
                {
                    Console.WriteLine("You are exiting the application!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    repeat = false;
                }
                else
                {
                    page = factory.GetMenu(currentPage);
                }
            }

        }
    }
}