using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Data;
using StoreModels;

namespace StoreDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    public class Repository : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../StoreDL/Database/";
        private string _jsonString;

        public Store AddStore(Store p_rest)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Store> listOfStores = GetAllStore();

            //We added the new restaurant from the parameter 
            listOfStores.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Store.json",_jsonString);

            //Will return a restaurant object from the parameter
            return p_rest;
        }


        public List<Store> GetAllStore()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"Store.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Store>>(_jsonString);
        }

        public List<Customer> GetAllCustomers()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"Customer.JSON");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public Customer AddCustomer(Customer p_customer){
             //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Customer> listOfCustomers = GetAllCustomers();

            //We added the new restaurant from the parameter 
            listOfCustomers.Add(p_customer);

            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Customer.JSON",_jsonString);

            //Will return a restaurant object from the parameter
            return p_customer;

        }

        public List<StoreFront> GetAllProducts()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"Products.JSON");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public StoreFront AddProducts(StoreFront p_products){
             //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<StoreFront> listOfProducts = GetAllProducts();

            //We added the new restaurant from the parameter 
            listOfProducts.Add(p_products);

            _jsonString = JsonSerializer.Serialize(listOfProducts, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Products.JSON",_jsonString);

            //Will return a restaurant object from the parameter
            return p_products;
            

        }

        public List<StoreFront> GetAllStoreFronts()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"StoreFronts.JSON");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }

        public StoreFront AddStoreFronts(StoreFront p_storefront){
             //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<StoreFront> listOfStoreFronts = GetAllStoreFronts();

            //We added the new restaurant from the parameter 
            listOfStoreFronts.Add(p_storefront);

            _jsonString = JsonSerializer.Serialize(listOfStoreFronts, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"StoreFronts.JSON",_jsonString);

            //Will return a restaurant object from the parameter
            return p_storefront;

        }

        public List<Orders> GetAllOrders()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"Orders.JSON");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Orders>>(_jsonString);
        }

        public Orders PlaceOrders(Orders p_orders){
             //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Orders> listOfOrders = GetAllOrders();

            //We added the new restaurant from the parameter 
            listOfOrders.Add(p_orders);

            _jsonString = JsonSerializer.Serialize(listOfOrders, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Orders.JSON",_jsonString);

            //Will return a restaurant object from the parameter
            return p_orders;

        }

    }
}
