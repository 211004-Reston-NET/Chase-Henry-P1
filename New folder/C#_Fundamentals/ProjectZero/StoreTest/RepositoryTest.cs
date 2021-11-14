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
                
                   
                context.SaveChanges();
            }
        }
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
    }
}