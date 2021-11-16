using Microsoft.EntityFrameworkCore;
using Xunit;
using StoreDL;
using StoreModels;
using System.Collections.Generic;
using System.Linq;

namespace StoreTest
{
    public class RepositoryTest
    {
        private readonly DbContextOptions<RRProject0Context> _options;
        public RepositoryTest()
        {
            _options = new DbContextOptionsBuilder<RRProject0Context>()
                        .UseSqlite("Filename = Test.db").Options;
            Seed();
        }
        //test21
        [Fact]
        public void getAllCustomersShouldReturnAllCustomers()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                var test = repo.GetAllCustomers();
                Assert.Equal(2, test.Count);
                Assert.Equal("Chase house", test[0].Name);
            }
        }

        private void Seed()
        {
            using (var context = new RRProject0Context(_options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Customer.AddRange
                (
                    new Customer
                    {
                        Name = "Chase house",
                        Address = "122 meme street",
                        Email = "test@gmail.com"
                    },
                    new Customer
                    {
                        Name = "Daves house",
                        Address = "122 sleep street",
                        Email = "tester@gmail.com"
                    }
                );
                context.LineItems.AddRange
                (
                    new LineItems
                    {
                        ItemId = 1,
                        Quantity = 10
                    },
                    new LineItems
                    {
                        ItemId = 2,
                        Quantity = 15
                    }
                );
                context.Orders.AddRange
                (
                    new Orders
                    {
                        OrderId = 1,
                        Total = 100,
                        CustId = 1,
                        prodId = 1,
                        StoreId = 1
                    },
                    new Orders
                    {
                        OrderId = 2,
                        Total = 150,
                        CustId = 2,
                        prodId = 2,
                        StoreId = 2
                    }
                );
                context.Products.AddRange
                (
                    new Products
                    {
                        ProdId = 1,
                        Name = "test",
                        Price = 100,
                        StoreId = 1,
                        ItemId = 1

                    }
                );
                context.StoreFronts.AddRange
                (
                    new StoreFront
                    {
                        Name = "Target",
                        Address = "1800 Test Street",
                        StoreId = 1

                    }
                );

                context.SaveChanges();
            }
        }
        //test22
        [Fact]
        public void DeleteOrderShouldDeleteOrder()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                Customer ord = new Customer
                {
                    CustId = 1,
                    Name = "Chad",
                    Address = "1800 Chad Street",
                    Email = "Chad@email.com"
                };
                repo.DeleteCustomer(ord);
            }
            using (var context = new RRProject0Context(_options))
            {
                List<Customer> listOfOrders = context.Customer.ToList();
                Assert.Single(listOfOrders);
                Assert.Null(context.Orders.Find(4));
            }
        }

        //test23
        [Fact]
        public void getAllLineItemsShouldReturnAllLineItems()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                var test = repo.GetAllLineItems();
                Assert.Equal(2, test.Count);
                Assert.Equal(1, test[0].ItemId);
                Assert.Equal(10, test[0].Quantity);
            }
        }

        //test24
        [Fact]
        public void getAllStoreOrdersShouldReturnAllStoreOrders()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                var test = repo.GetAllStoreOrders();
                Assert.Equal(1, test[0].OrderId);
              
                Assert.Equal(100, test[0].Total);
                Assert.Equal(150, test[1].Total);
            }
        }
        //test25
        [Fact]
        public void getAllStoreFrontsShouldReturnAllStoreFronts()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                var test = repo.GetAllStoreFronts();
                Assert.Equal("Target", test[0].Name);
                Assert.Equal("1800 Test Street", test[0].Address);

            }
        }

        //test26
        [Fact]
        public void getAllProductsShouldReturnAllProducts()
        {
            using (var context = new RRProject0Context(_options))
            {
                IRepository repo = new RepositoryCloud(context);
                var test = repo.GetAllProducts();
                Assert.Equal(1, test[0].ProdId);
                Assert.Equal("test", test[0].Name);
            }
        }

    }
}