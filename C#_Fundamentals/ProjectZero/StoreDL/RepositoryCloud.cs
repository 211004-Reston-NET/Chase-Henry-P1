using System.Collections.Generic;
using StoreDL;
using StoreModels;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;

namespace StoreDL{
    public class RepositoryCloud : IRepository
    {
        private Entity.RRProject0Context _context;

        public RepositoryCloud(Entity.RRProject0Context p_context){
            _context = p_context;
        }
        public Store AddStore(Store p_rest)
        {
            throw new System.NotImplementedException();
        }

        public List<Store> GetAllStore()
        {
            throw new System.NotImplementedException();
        }

        public Customer AddCustomer(Model.Customer p_customer)
        {
            _context.Customers.Add(
                new Entity.Customer() {
                    Name = p_customer.Name,
                    Address = p_customer.Address,
                    Email = p_customer.Email
                }
            );
            _context.SaveChanges();

            return p_customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.Select(cust =>
                new Model.Customer(){
                    Name = cust.Name,
                    Address = cust.Address,
                    Email = cust.Email
                }
            ).ToList();
        }

        public StoreFront AddProducts(StoreFront p_products)
        {
            throw new System.NotImplementedException();
        }

        public List<StoreFront> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public StoreFront AddStoreFronts(StoreFront p_storefront)
        {
            throw new System.NotImplementedException();
        }

        public List<StoreFront> GetAllStoreFronts()
        {
            throw new System.NotImplementedException();
        }

        public List<Orders> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public Orders PlaceOrders(Orders p_orders)
        {
            throw new System.NotImplementedException();
        }
    }
}