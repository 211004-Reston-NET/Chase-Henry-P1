using System.Collections.Generic;
using StoreModels;

namespace SBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// demo class
        /// </summary>
        /// <returns></returns>
        List<Store> GetAllStore();

        /// <summary>
        /// demo class
        /// </summary>
        /// <param name="p_rest"></param>
        /// <returns></returns>
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
        /// will return a customer based on name
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
        /// Adds a store front to the database
        /// </summary>
        /// <param name="p_storefront">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        StoreFront AddStoreFronts(StoreFront p_storefront);

       /// <summary>
       /// will return a list of storefronts from the database
       /// </summary>
       /// <returns></returns>
        List<StoreFront> GetAllStoreFronts();

        /// <summary>
        /// Will find multiple storefronts given a name
        /// </summary>
        /// <param name="p_storefront">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<StoreFront> GetStoreFront(string p_storefront);

       /// <summary>
       /// will return a list of all orders in the database.
       /// </summary>
       /// <returns></returns>
        List<Orders> GetAllOrders();

         /// <summary>
        /// Adds a order to the database
        /// </summary>
        /// <param name="p_orders">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Orders PlaceOrders(Orders p_orders);

         /// <summary>
        /// Will find multiple orders given a name
        /// </summary>
        /// <param name="p_orders">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Orders> GetOrders(string p_orders);

        /// <summary>
        /// This will return a list of all customer orders
        /// </summary>
        /// <returns></returns>
        List<Orders> GetAllCustomerOrders();

        /// <summary>
        /// this will return a list of all store orders
        /// </summary>
        /// <returns></returns>
        List<Orders> GetAllStoreOrders();

        /// <summary>
        /// gets a customers orders by name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Orders> GetCustomerOrders(int p_name);

        /// <summary>
        /// Gets all store orders by given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Orders> GetAllStoreOrdersById(int p_id);
        
        /// <summary>
        /// gets all customer orders by given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Orders> GetAllCustomerOrdersById(int p_id);

        /// <summary>
        /// Gets a list of all line items from teh database
        /// </summary>
        /// <returns></returns>
        List<LineItems> GetAllLineItems();

        /// <summary>
        /// Deletes a customer from the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        Customer DeleteCustomer(Customer p_customer);

        /// <summary>
        /// gets a customer by given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Customer GetCustomerById(int p_id);

        /// <summary>
        /// gets a specific product by given store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Products> GetProductByStoreId(int p_id);

        /// <summary>
        /// gets all products by given store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<QuantityModel> GetAllProductByStoreId(int p_id);

        /// <summary>
        /// Gets a list of lineitems by given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<LineItems> GetAllLineItemsById(int p_id);

        /// <summary>
        /// Increases quantity by +1 then sends the updated value back to the database.
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<LineItems> AddInventory(int p_id);

        /// <summary>
        /// Increases quantity by +1 then sends the updated value back to the database.
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        LineItems AddInvent(int p_id);

        /// <summary>
        /// Gets a lineitem by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        LineItems GetLineItemById(int p_id);

        /// <summary>
        /// Sorts orders by cost in descending order.
        /// </summary>
        /// <returns></returns>
        List<Orders> GetSortOrder();

    }
}