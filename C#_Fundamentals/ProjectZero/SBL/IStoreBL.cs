using System.Collections.Generic;
using StoreModels;

namespace SBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Store AddStore(Store p_rest);

        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="p_customer">This is the customer we are adding</param>
        /// <returns>It returns the added customer</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// This will return a list of customers stored in the database
        /// It will also capitalize every name of the customer
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Customer> GetAllCustomers();

        /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Customer> GetCustomer(string p_name);

        /// <summary>
        /// Adds a product to the database
        /// </summary>
        /// <param name="p_products">This is the product we are adding</param>
        /// <returns>It returns the added product</returns>
        StoreFront AddProducts(StoreFront p_products);

        /// <summary>
        /// This will return a list of products stored in the database
        /// It will also capitalize every name of the product
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Products> GetAllProducts();

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="p_storefront">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        StoreFront AddStoreFronts(StoreFront p_storefront);

        /// <summary>
        /// This will return a list of products stored in the database
        /// It will also capitalize every name of the product
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<StoreFront> GetAllStoreFronts();

        /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_storefront">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<StoreFront> GetStoreFront(string p_storefront);

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Orders> GetAllOrders();

         /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="p_orders">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Orders PlaceOrders(Orders p_orders);

         /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_orders">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Orders> GetOrders(string p_orders);

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Orders> GetAllCustomerOrders();

        /// <summary>
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Orders> GetAllStoreOrders();

        /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Orders> GetCustomerOrders(int p_name);
        List<Orders> GetAllStoreOrdersById(int p_id);
    }
}