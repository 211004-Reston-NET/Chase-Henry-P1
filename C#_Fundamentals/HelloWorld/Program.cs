using System;
using HouseFunction;
/*
PascelCase is used for most parts and is EverythingIsCapitalized
camelCase is for naming fields and it is everythingAfterTheFirstWord
*/

namespace HelloWorld
{
    class Program
        //static means, I dont have to instantiate the program class to use that method
        //void means that nothing will be given back

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //this is if you dont make the method static
            //Program test = new Program();
            //test.Example();
            Program.Example();

            House Stephen = new House();
            Stephen.MiceName = "Jerry";
            Stephen.Owner = "Colin";
            Console.WriteLine(Stephen.MiceName);
            Console.WriteLine(Stephen.Owner);
            Console.WriteLine(Stephen.owner);

            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered is "+input);

            Collection collectionObj = new Collection();

        }
        public static int Example()
        {
            return 10;
        }
    }
}
