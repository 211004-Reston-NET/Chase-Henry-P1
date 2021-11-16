using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        /// <summary>
        /// Dummy method
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Store AddStore(Store p_rest);

        /// <summary>
        /// dummy method
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// It will add a customer in our database
        /// </summary>
        /// <param name="p_customer">This is the customer we will be adding to the database</param>
        /// <returns>It will just return the customer we are adding</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// get all customers from the database
        /// </summary>
        /// <returns>It will just return the customer we are adding</returns>
        List<Customer> GetAllCustomers();

        /// <summary>
        /// It will add a product in our database
        /// </summary>
        /// <param name="p_products">This is the product we will be adding to the database</param>
        /// <returns>It will just return the product we are adding</returns>
        StoreFront AddProducts(StoreFront p_products);

         /// <summary>
        /// This will return a list of products stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Products> GetAllProducts();

        /// <summary>
        /// It will add a storefront in our database
        /// </summary>
        /// <param name="p_storefront">This is the product we will be adding to the database</param>
        /// <returns>It will just return the product we are adding</returns>
        StoreFront AddStoreFronts(StoreFront p_storefront);

         /// <summary>
        /// This will return a list of storefronts stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<StoreFront> GetAllStoreFronts();

         /// <summary>
        /// This will return a list of orders stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllOrders();

        /// <summary>
        /// It will add a order in our database
        /// </summary>
        /// <param name="p_orders">This is the product we will be adding to the database</param>
        /// <returns>It will just return the product we are adding</returns>
        Orders PlaceOrders(Orders p_orders);

         /// <summary>
        /// Gets all customer orders in a list from the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllCustomerOrders();

         /// <summary>
        /// This will return a list of all store orders from the db
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllStoreOrders();

        /// <summary>
        /// returns a list of all store orders based on the given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Orders> GetAllStoreOrdersById(int p_id);

        /// <summary>
        /// returns a list of all customer orders based on the given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Orders> GetAllCustomerOrdersById(int p_id);

        /// <summary>
        /// returns a list of all lineitems
        /// </summary>
        /// <returns></returns>
        List<LineItems> GetAllLineItems();

        /// <summary>
        /// deletes a customer from the database
        /// </summary>
        /// <param name="p_Customer"></param>
        /// <returns></returns>
        Customer DeleteCustomer(Customer p_Customer);

        /// <summary>
        /// gets a customer by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        Customer GetCustomerById(int p_id);

        /// <summary>
        /// gets a product by a given store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        List<Products> GetProductByStoreId(int p_id);

        /// <summary>
        /// gets all products by a given store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
       List<QuantityModel> GetAllProductByStoreId(int p_id);

        /// <summary>
        /// gets a linneitems by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
       List<LineItems> GetAllLineItemsById(int p_id);

        /// <summary>
        /// increases quantity by +1 and updates the database
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
       List<LineItems> AddInventory(int p_id);

        /// <summary>
        /// increases quantity by +1 and updates the database
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        LineItems AddInvent(int p_id);

        /// <summary>
        /// gets a lineitem by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        LineItems GetLineItemById(int p_id);


        /// <summary>
        /// sorts orders by total in descending order
        /// </summary>
        /// <returns></returns>
        List<Orders> GetSortOrder();
    }

}