using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Store AddStore(Store p_rest);

        /// <summary>
        /// This will return a list of restaurants stored in the database
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
        /// It will add a customer in our database
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
        /// It will add a product in our database
        /// </summary>
        /// <param name="p_storefront">This is the product we will be adding to the database</param>
        /// <returns>It will just return the product we are adding</returns>
        StoreFront AddStoreFronts(StoreFront p_storefront);

         /// <summary>
        /// This will return a list of products stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<StoreFront> GetAllStoreFronts();

         /// <summary>
        /// This will return a list of products stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllOrders();

        /// <summary>
        /// It will add a product in our database
        /// </summary>
        /// <param name="p_orders">This is the product we will be adding to the database</param>
        /// <returns>It will just return the product we are adding</returns>
        Orders PlaceOrders(Orders p_orders);

         /// <summary>
        /// This will return a list of products stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllCustomerOrders();

         /// <summary>
        /// This will return a list of products stored in the database
        /// </summary>
        /// <returns>It will return a list of products</returns>
        List<Orders> GetAllStoreOrders();
        List<Orders> GetAllStoreOrdersById(int p_id);

        List<Orders> GetAllCustomerOrdersById(int p_id);

        List<LineItems> GetAllLineItems();

        Customer DeleteCustomer(Customer p_Customer);

        Customer GetCustomerById(int p_id);

        List<Products> GetProductByStoreId(int p_id);

       List<QuantityModel> GetAllProductByStoreId(int p_id);
    }

}