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

        /// <summary>
        /// Demo Class
        /// </summary>
        /// <param name="p_rest"></param>
        /// <returns></returns>
        public Store AddStore(Store p_rest)
        {
            return _repo.AddStore(p_rest);
        }

        /// <summary>
        /// Demo Class
        /// </summary>
        /// <returns></returns>
        public List<Store> GetAllStore()
        {
            List<Store> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].Name = listOfStore[i].Name.ToLower();
            }

            return listOfStore;
        }

        /// <summary>
        /// Adds a Customer to the Database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        public Customer AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer);
        }

        /// <summary>
        /// Gets a list of all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            //Gets a list of all customers
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].Name = listOfCustomer[i].Name.ToLower();
            }

            return listOfCustomer;
        }


        /// <summary>
        /// Adds a product to the database
        /// </summary>
        /// <param name="p_products"></param>
        /// <returns></returns>
        public StoreFront AddProducts(StoreFront p_products)
        {
            return _repo.AddProducts(p_products);
        }

        /// <summary>
        /// Gets a list of all products from the database
        /// </summary>
        /// <returns></returns>
        public List<Products> GetAllProducts()
        {
            List<Products> listOfProducts = _repo.GetAllProducts();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                listOfProducts[i].Name = listOfProducts[i].Name.ToLower();
            }

            return listOfProducts;
        }

        /// <summary>
        /// Returns a list of customers based on specified name from the database.
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        public List<Customer> GetCustomer(string p_name)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomers();

            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(cust => cust.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }

        /// <summary>
        /// Returns a list of all storefronts in the database.
        /// </summary>
        /// <returns></returns>
        public List<StoreFront> GetAllStoreFronts()
        {
            List<StoreFront> listOfStoreFronts = _repo.GetAllStoreFronts();
            for (int i = 0; i < listOfStoreFronts.Count; i++)
            {
                listOfStoreFronts[i].Name = listOfStoreFronts[i].Name.ToLower();
            }

            return listOfStoreFronts;
        }

        /// <summary>
        /// Adds a storefront to the database
        /// </summary>
        /// <param name="p_storefront"></param>
        /// <returns></returns>
        public StoreFront AddStoreFronts(StoreFront p_storefront)
        {
            return _repo.AddStoreFronts(p_storefront);
        }

        /// <summary>
        /// Returns a specific storefront based on a input name
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        public List<StoreFront> GetStoreFront(string p_name)
        {
            List<StoreFront> listOfStoreFronts = _repo.GetAllStoreFronts();

            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfStoreFronts.Where(storefront => storefront.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }

        /// <summary>
        /// Return a list of all orders from the database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Creates a new order in the database.
        /// </summary>
        /// <param name="p_orders"></param>
        /// <returns></returns>
        public Orders PlaceOrders(Orders p_orders)
        {
            return _repo.PlaceOrders(p_orders);
        }

        /// <summary>
        /// Demo Class. Not implemented
        /// </summary>
        /// <param name="p_orders"></param>
        /// <returns></returns>
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

        /// <summary>
        /// returns a list of all orders based on customer ID.
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetAllCustomerOrders()
        {

            List<Orders> listOfCustomerOrders = _repo.GetAllCustomerOrders();
            for (int i = 0; i < listOfCustomerOrders.Count; i++)
            {
                listOfCustomerOrders[i].CustId = listOfCustomerOrders[i].CustId;
            }

            return listOfCustomerOrders;
        }

        /// <summary>
        /// returns a list of all orders based on store id.
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetAllStoreOrders()
        {

            List<Orders> listOfStoreOrders = _repo.GetAllStoreOrders();
            for (int i = 0; i < listOfStoreOrders.Count; i++)
            {
                listOfStoreOrders[i].Total = listOfStoreOrders[i].Total;
            }

            return listOfStoreOrders;
        }

        /// <summary>
        /// returns a list of customer orders based on a given name
        /// </summary>
        /// <param name="p_name"></param>
        /// <returns></returns>
        public List<Orders> GetCustomerOrders(int p_name)
        {
            List<Orders> listOfCustomer = _repo.GetAllCustomerOrders();

            //Select method will give a list of boolean if the condition was true/false
            //Where method will give the actual element itself based on some condition
            //ToList method will convert into List that our method currently needs to return.
            //ToLower will lowercase the string to make it not case sensitive
            return listOfCustomer.Where(cust => cust.CustId == (p_name)).ToList();
        }

        /// <summary>
        /// returns a list of orders based on a given store id.
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Orders> GetAllStoreOrdersById(int p_id)
        {
            return _repo.GetAllStoreOrdersById(p_id);
        }

        /// <summary>
        /// returns a list of orders based on a given customer id.
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Orders> GetAllCustomerOrdersById(int p_id)
        {
            return _repo.GetAllCustomerOrdersById(p_id);
        }

        /// <summary>
        /// returns a list of all line items
        /// </summary>
        /// <returns></returns>
        public List<LineItems> GetAllLineItems()
        {
            List<LineItems> listOfStoreOrders = _repo.GetAllLineItems();
            for (int i = 0; i < listOfStoreOrders.Count; i++)
            {
                listOfStoreOrders[i].ItemId = listOfStoreOrders[i].ItemId;
            }

            return listOfStoreOrders;
        }

        /// <summary>
        /// deletes a customer from the database.
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        public Customer DeleteCustomer(Customer p_customer)
        {
            return _repo.DeleteCustomer(p_customer);
        }

        /// <summary>
        /// gets a specific customer by their custid
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int p_id)
        {
            Customer custFound = _repo.GetCustomerById(p_id);

            if (custFound == null)
            {
                throw new Exception("No Customer Was Found");
            }
            return custFound;
        }

        /// <summary>
        /// gets a list of products by store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Products> GetProductByStoreId(int p_id)
        {
            return _repo.GetProductByStoreId(p_id);
        }

        /// <summary>
        /// gets a list of products by store id that also shows product quantity from lineitems
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<QuantityModel> GetAllProductByStoreId(int p_id)
        {
            return _repo.GetAllProductByStoreId(p_id);
        }

        /// <summary>
        /// gets a list of all lineitems by given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<LineItems> GetAllLineItemsById(int p_id)
        {
            return _repo.GetAllLineItemsById(p_id);
        }

        /// <summary>
        /// increases the quantity of lineitems in the database by +1
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<LineItems> AddInventory(int p_id)
        {
            return _repo.AddInventory(p_id);
        }

        /// <summary>
        /// increases the quantity of lineitems in the database by +1
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public LineItems AddInvent(int p_id)
        {
            return _repo.AddInvent(p_id);
        }

        /// <summary>
        /// gets a specific lineitem by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public LineItems GetLineItemById(int p_id)
        {
            return _repo.GetLineItemById(p_id);
        }

        /// <summary>
        /// sorts orders by cost in descending order.
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetSortOrder()
        {
            return _repo.GetSortOrder();
        }
    }
}