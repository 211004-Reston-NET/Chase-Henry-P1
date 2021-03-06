using System.Collections.Generic;
using StoreDL;
using StoreModels;
using Model = StoreModels;
//using Entity = StoreDL.Entities;
using System.Linq;

namespace StoreDL{
    public class RepositoryCloud : IRepository
    {
        private RRProject0Context _context;

        public RepositoryCloud(RRProject0Context p_context){
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

        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        public Customer AddCustomer(Model.Customer p_customer)
        {
            _context.Customer.Add(
                new Customer() {
                    Name = p_customer.Name,
                    Address = p_customer.Address,
                    Email = p_customer.Email
                }
            );
            _context.SaveChanges();

            return p_customer;
        }

        /// <summary>
        /// gets a list of all customers from the database
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            return _context.Customer.Select(cust =>
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

        /// <summary>
        /// gets a list of all products from the database
        /// </summary>
        /// <returns></returns>
        public List<Products> GetAllProducts()
        {
            return _context.Products.Select(sf =>
                new Model.Products(){
                    Name = sf.Name,
                    Price = sf.Price,
                    ProdId = sf.ProdId,
                    StoreId = sf.StoreId
                }
            ).ToList();
        }

        /// <summary>
        /// adds a storefront to the database
        /// </summary>
        /// <param name="p_storefront"></param>
        /// <returns></returns>
        public StoreFront AddStoreFronts(Model.StoreFront p_storefront)
        {
            _context.StoreFronts.Add(
                new StoreFront(){
                    Name = p_storefront.Name,
                    Address = p_storefront.Address
                }
            );
            _context.SaveChanges();

            return p_storefront;
        }

        /// <summary>
        /// gets a list of all storefronts from the database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// gets a list of all orders from the database
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetAllOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    Total = ord.Total ?? 0,
                    CustId = ord.CustId,
                    StoreId = ord.StoreId,
                    prodId = ord.prodId
                }
            ).ToList();
        }

        /// <summary>
        /// adds an order to the database
        /// </summary>
        /// <param name="p_orders"></param>
        /// <returns></returns>
        public Orders PlaceOrders(Model.Orders p_orders)
        {
            _context.Orders.Add(
                new Orders() {
                    CustId = p_orders.CustId,
                    StoreId = p_orders.StoreId,
                    prodId = p_orders.prodId,
                    Total = p_orders.Total
                }
            );
            _context.SaveChanges();

            return p_orders;
        }

        /// <summary>
        /// gets a list of all customer orders from the database
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetAllCustomerOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    prodId = ord.prodId,
                    Total = ord.Total ?? 0
                }
            ).ToList();
        }

        /// <summary>
        /// gets a list of all store orders from the database
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetAllStoreOrders()
        {
            return _context.Orders.Select(ord =>
                new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    prodId = ord.prodId,
                    Total = ord.Total ?? 0
                }
            ).ToList();
        }

        /// <summary>
        /// gets all store orders by id from the database
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Orders> GetAllStoreOrdersById(int p_id)
        {
            return _context.Orders.Where(ord => ord.StoreId == p_id)
                    .Select(ord => 
                    new Model.Orders(){
                    OrderId = ord.OrderId,
                    StoreId = ord.StoreId,
                    CustId = ord.CustId,
                    prodId = ord.prodId,
                    Total = ord.Total ?? 0
                    }).ToList();
        }

        /// <summary>
        /// gets all customer orders by id from the database
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Orders> GetAllCustomerOrdersById(int p_id)
        {
            return _context.Orders.Where(ord => ord.CustId == p_id)
                    .Select(ord =>
                    new Model.Orders()
                    {
                        OrderId = ord.OrderId,
                        StoreId = ord.StoreId,
                        CustId = ord.CustId,
                        prodId = ord.prodId,
                        Total = ord.Total ?? 0
                    }).ToList();
        }

        /// <summary>
        /// gets a list of all lineitems from the database
        /// </summary>
        /// <returns></returns>
        public List<LineItems> GetAllLineItems()
        {
            return _context.LineItems.Select(li =>
                new Model.LineItems(){
                    ItemId = li.ItemId,
                    Quantity = li.Quantity ?? 0
                }
            ).ToList();
        }

        /// <summary>
        /// deletes a selected customer from the database
        /// </summary>
        /// <param name="p_customer"></param>
        /// <returns></returns>
        public Customer DeleteCustomer(Customer p_customer)
        {
            _context.Customer.Remove(p_customer);
            _context.SaveChanges();
            return p_customer;
        }

        /// <summary>
        /// gets a specific customer by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int p_id)
        {
            return _context.Customer.Find(p_id);
        }

        /// <summary>
        /// gets a specific lineitem by a given id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public LineItems GetLineItemById(int p_id)
        {
            return _context.LineItems.Find(p_id);
        }

        /// <summary>
        /// gets a products by a given store id
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<Products> GetProductByStoreId(int p_id)
        {
            return _context.Products.Where(ord => ord.StoreId == p_id)
                    .Select(ord =>
                    new Model.Products()
                    {
                        Name = ord.Name,
                        StoreId = ord.StoreId,
                        Price = ord.Price,
                        ProdId = ord.ProdId
                    }).ToList();
        }

        /// <summary>
        /// gets all lineitems by a given id from the database
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<LineItems> GetAllLineItemsById(int p_id)
        {
            return _context.LineItems.Where(ord => ord.ItemId == p_id)
                    .Select(ord =>
                    new Model.LineItems()
                    {
                        ItemId = ord.ItemId,
                        Quantity = ord.Quantity
                    }).ToList();
        }

        /// <summary>
        /// joins products and lineitems into a new model called quantitymodel then returns the joined list
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<QuantityModel> GetAllProductByStoreId(int p_id)
        {
                    var _listOfAllProductsByStoreId = (from p in _context.Products
                                                        join li in _context.LineItems 
                                                        on p.ItemId equals li.ItemId
                                                        where p.StoreId == p_id
                                                        select new QuantityModel{
                                                            ProdId = p.ProdId,
                                                            Name = p.Name,
                                                            Price = p.Price,
                                                            StoreId = p.StoreId,
                                                            ItemId = p.ItemId,
                                                            Quantity = li.Quantity
                                                        }).ToList();

            return _listOfAllProductsByStoreId;
        }

        /// <summary>
        /// adds +1 to quantity and then returns the updated value
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public List<LineItems> AddInventory(int p_id)
        {
            var _listOfAllProductsByStoreId = (from li in _context.LineItems
                                               where li.ItemId == p_id
                                               select new LineItems
                                               {
                                                   ItemId = li.ItemId,
                                                   Quantity = li.Quantity + 1
                                               }).ToList();
            _context.Update(_listOfAllProductsByStoreId);
            _context.SaveChanges();
            return _listOfAllProductsByStoreId;
        }

        /// <summary>
        /// WIP add invent class. 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public LineItems AddInvent(int p_id)
        {
            var _listOfAllProductsByStoreId = _context.LineItems.FirstOrDefault(a => a.ItemId == p_id);
           _listOfAllProductsByStoreId.Quantity = _listOfAllProductsByStoreId.Quantity + 1;
            _context.SaveChanges();
            return _listOfAllProductsByStoreId;
        }

        /// <summary>
        /// returns a list of orders sorted by total price in descending order
        /// </summary>
        /// <returns></returns>
        public List<Orders> GetSortOrder()
        {
            var _sort = (from o in _context.Orders
                         orderby o.Total
                         select o

                ).ToList();
            return _sort;
        }

    }
    }