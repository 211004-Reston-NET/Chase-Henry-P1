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
                    Total = ord.Total ?? 0,
                    CustId = ord.CustId,
                    StoreId = ord.StoreId,
                    prodId = ord.prodId
                }
            ).ToList();
        }

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

        public List<LineItems> GetAllLineItems()
        {
            return _context.LineItems.Select(li =>
                new Model.LineItems(){
                    ItemId = li.ItemId,
                    Quantity = li.Quantity ?? 0
                }
            ).ToList();
        }

        public Customer DeleteCustomer(Customer p_customer)
        {
            _context.Customer.Remove(p_customer);
            _context.SaveChanges();
            return p_customer;
        }

        public Customer GetCustomerById(int p_id)
        {
            return _context.Customer.Find(p_id);
        }
        
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

        public List<Products> GetAllProductByStoreId(int p_id)
        {
            List<Products> tester = new List<Products>();
            using (RRProject0Context _context = new RRProject0Context())
            {
                    var _listOfAllProductsByStoreId = (from p in _context.Products
                                                        join li in _context.LineItems 
                                                        on p.ItemId equals li.ItemId
                                                        where p.StoreId == p_id
                                                        select new {
                                                            ProdId = p.ProdId,
                                                            Name = p.Name,
                                                            Price = p.Price,
                                                            StoreId = p.StoreId,
                                                            ItemId = p.ItemId,
                                                            Quantity = li.Quantity
                                                        });
                                                    //tester = _listOfAllProductsByStoreId.ToList();
            }

            return tester;
    
            // foreach (var item in _listOfAllProductsByStoreId)
                    // {
                    //     Products _item = new Products()
                    //     {
                    //         ProdId = item.ProdId,
                    //         Name = item.Name,
                    //         Price = item.Price,
                    //         StoreId = item.StoreId,
                    //         ItemId = item.ItemId,
                    //         Quantity = item.Quantity
                    //     };
                    // return _listOfAllProductsByStoreId.Add(_context);
                    // }
        }
    }
}