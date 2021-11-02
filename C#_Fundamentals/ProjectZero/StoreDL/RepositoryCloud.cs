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
        public Store AddStore(Model.Store p_rest)
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
                    CustId = cust.CustId,
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

        public List<Products> GetAllProducts()
        {
            return _context.Products.Select(sf =>
                new Model.Products(){
                    Name = sf.Name,
                    Price = sf.Price,
                    ProdId = sf.ProdId
                }
            ).ToList();
        }

        public StoreFront AddStoreFronts(Model.StoreFront p_storefront)
        {
            _context.StoreFronts.Add(
                new Entity.StoreFront(){
                    Name = p_storefront.Name,
                    Address = p_storefront.Address
                }
            );
            _context.SaveChanges();

            return p_storefront;
        }

        public List<StoreFront> GetAllStoreFronts()
        {
           return _context.StoreFronts.Select(sf =>
                new Model.StoreFront(){
                    Name = sf.Name,
                    Address = sf.Address,
                    StoreId = sf.StoreId
                }
            ).ToList();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    Total = ord.Total ?? 0
                }
            ).ToList();
        }

        public Orders PlaceOrders(Model.Orders p_orders)
        {
            _context.Orders.Add(
                new Entity.Order() {
                    CustId = p_orders.CustId,
                    StoreId = p_orders.StoreId,
                    Total = p_orders.Total
                }
            );
            _context.SaveChanges();

            return p_orders;
        }

        public List<Orders> GetAllCustomerOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    Total = ord.Total ?? 0
                }
            ).ToList();
        }

        public List<Orders> GetAllStoreOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    Total = ord.Total ?? 0
                }
            ).ToList();
        }

        public List<Orders> GetAllStoreOrdersById(int p_id)
        {
            return _context.Orders.Where(ord => ord.StoreId == p_id)
                    .Select(ord => 
                    new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    Total = ord.Total ?? 0
                    }).ToList();
        }
    }
}