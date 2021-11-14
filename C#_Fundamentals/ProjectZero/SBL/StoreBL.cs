using System;
using System.Collections.Generic;
using System.Linq;
using StoreDL;
using StoreModels;

namespace SBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class StoreBL : IStoreBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Store AddStore(Store p_rest)
        {
            return _repo.AddStore(p_rest);
        }

        public List<Store> GetAllStore()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Store> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].Name = listOfStore[i].Name.ToLower(); 
            }

            return listOfStore;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer);
        }

         public List<Customer> GetAllCustomers()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].Name = listOfCustomer[i].Name.ToLower(); 
            }

            return listOfCustomer;
        }

        

        public StoreFront AddProducts(StoreFront p_products)
        {
            return _repo.AddProducts(p_products);
        }

         public List<Products> GetAllProducts()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Products> listOfProducts = _repo.GetAllProducts();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                listOfProducts[i].Name = listOfProducts[i].Name.ToLower(); 
            }

            return listOfProducts;
        }

        public List<Customer> GetCustomer(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(cust => cust.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public List<StoreFront> GetAllStoreFronts()
        {
            List<StoreFront> listOfStoreFronts = _repo.GetAllStoreFronts();
            for (int i = 0; i < listOfStoreFronts.Count; i++)
            {
                listOfStoreFronts[i].Name = listOfStoreFronts[i].Name.ToLower(); 
            }

            return listOfStoreFronts;
        }

        public StoreFront AddStoreFronts(StoreFront p_storefront)
        {
            return _repo.AddStoreFronts(p_storefront);
        }

        public List<StoreFront> GetStoreFront(string p_name)
        {
            List<StoreFront> listOfStoreFronts = _repo.GetAllStoreFronts();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfStoreFronts.Where(storefront => storefront.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public List<Orders> GetAllOrders()
        {
            List<Orders> listOfProducts = _repo.GetAllOrders();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                listOfProducts[i].OrderId = listOfProducts[i].OrderId;
            }

            return listOfProducts;

            //return listOfOrders;
        }

        public Orders PlaceOrders(Orders p_orders)
        {
            return _repo.PlaceOrders(p_orders);
        }

        public List<Orders> GetOrders(string p_orders)
        {
            // List<Orders> listOfOrders = _repo.GetAllOrders();
            
            // //Select method will give a list of boolean if the condition was true/false
            // //Where method will give the actual element itself based on some condition
            // //ToList method will convert into List that our method currently needs to return.
            // //ToLower will lowercase the string to make it not case sensitive
            // return listOfOrders.Where(orders => orders.ListOfLineItems.ToLower().Contains(p_orders.ToLower())).ToList();
            throw new System.NotImplementedException();
        }

        public List<Orders> GetAllCustomerOrders()
        {
            
            List<Orders> listOfCustomerOrders = _repo.GetAllCustomerOrders();
            for (int i = 0; i < listOfCustomerOrders.Count; i++)
            {
                listOfCustomerOrders[i].CustId = listOfCustomerOrders[i].CustId; 
            }

            return listOfCustomerOrders;
        }

        public List<Orders> GetAllStoreOrders()
        {
            
            List<Orders> listOfStoreOrders = _repo.GetAllStoreOrders();
            for (int i = 0; i < listOfStoreOrders.Count; i++)
            {
                listOfStoreOrders[i].Total = listOfStoreOrders[i].Total; 
            }

            return listOfStoreOrders;
        }

        public List<Orders> GetCustomerOrders(int p_name)
        {
            List<Orders> listOfCustomer = _repo.GetAllCustomerOrders();
            
            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(cust => cust.CustId==(p_name)).ToList();
        }

        public List<Orders> GetAllStoreOrdersById(int p_id){
            return _repo.GetAllStoreOrdersById(p_id);
        }

        public List<Orders> GetAllCustomerOrdersById(int p_id)
        {
            return _repo.GetAllCustomerOrdersById(p_id);
        }

        public List<LineItems> GetAllLineItems()
        {
            List<LineItems> listOfStoreOrders = _repo.GetAllLineItems();
            for (int i = 0; i < listOfStoreOrders.Count; i++)
            {
                listOfStoreOrders[i].ItemId = listOfStoreOrders[i].ItemId; 
            }

            return listOfStoreOrders;
        }

        public Customer DeleteCustomer(Customer p_customer)
        {
            return _repo.DeleteCustomer(p_customer);
        }

        public Customer GetCustomerById(int p_id)
        {
            Customer custFound = _repo.GetCustomerById(p_id);

            if (custFound == null)
            {
                throw new Exception("No Customer Was Found");  
            }
            return custFound;
        }

        public List<Products> GetProductByStoreId(int p_id){
            return _repo.GetProductByStoreId(p_id);
        }

        public List<QuantityModel> GetAllProductByStoreId(int p_id)
        {
            return _repo.GetAllProductByStoreId(p_id);
        }
    }
}