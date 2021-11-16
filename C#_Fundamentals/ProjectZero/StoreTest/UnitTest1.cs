using System;
using StoreModels;
using Xunit;

namespace StoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Customer _custTest = new Customer();
            string Name = "steve";

            //act
            _custTest.Name = Name;

            //assert
            Assert.NotNull(_custTest.Name);
            Assert.Equal(_custTest.Name, Name);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            Orders _orderTest = new Orders();
            int OrderId = 1;

            //act
            _orderTest.OrderId = OrderId;

            //assert
            //Assert.NotNull(_orderTest.OrderId);
            Assert.Equal(_orderTest.OrderId, OrderId);
        }

        [Fact]
        public void Test3(){
            Products _prodTest = new Products();
            int ProdId = 1;

            //act
            _prodTest.ProdId = ProdId;

            //assert
            //Assert.NotNull(_prodTest.ProdId);
            Assert.Equal(_prodTest.ProdId, ProdId);

        }
        [Fact]
        public void Test4(){
            StoreFront _sfTest = new StoreFront();
            string Name = "Best Buy";

            //act
            _sfTest.Name = Name;

            //assert
            Assert.NotNull(_sfTest.Name);
            Assert.Equal(_sfTest.Name, Name);

        }
        [Fact]
        public void Test5(){
            LineItems _liTest = new LineItems();
            int ItemId = 1;

            //act
            _liTest.ItemId = ItemId;

            //assert
            //Assert.NotNull(_liTest.ItemId);
            Assert.Equal(_liTest.ItemId, ItemId);

        }
        [Fact]
        public void Test6(){
             //Arrange
            Orders _orderTest = new Orders();
            int CustId = 1;

            //act
            _orderTest.CustId = CustId;

            //assert
            Assert.NotNull(_orderTest.CustId);
            Assert.Equal(_orderTest.CustId, CustId);
        }
        [Fact]
        public void Test7(){
             //Arrange
            Orders _orderTest = new Orders();
            int StoreId = 1;

            //act
            _orderTest.StoreId = StoreId;

            //assert
            Assert.NotNull(_orderTest.StoreId);
            Assert.Equal(_orderTest.StoreId, StoreId);
        }
        [Fact]
        public void Test8(){
            Products _prodTest = new Products();
            int Price = 1;

            //act
            _prodTest.Price = Price;

            //assert
            Assert.NotNull(_prodTest.Price);
            Assert.Equal(_prodTest.Price, Price);

        }
        [Fact]
        public void Test9(){
            Products _prodTest = new Products();
            int StoreId = 1;

            //act
            _prodTest.StoreId = StoreId;

            //assert
            Assert.NotNull(_prodTest.StoreId);
            Assert.Equal(_prodTest.StoreId, StoreId);
        }
        [Fact]
        public void Test10(){
            LineItems _quanTest = new LineItems();
            int Quantity = 20;

            //act
            _quanTest.Quantity = Quantity;

            //assert
            Assert.NotNull(_quanTest.Quantity);
            Assert.Equal(_quanTest.Quantity, Quantity);
        }

        [Fact]
        public void Test11()
        {
            UserProfile _up = new UserProfile();
            string UserName = "admin";

            //act
            _up.UserName = UserName;

            //assert
            Assert.NotNull(_up.UserName);
            Assert.Equal(_up.UserName, UserName);

        }

        [Fact]
        public void Test12()
        {
            UserProfile _up = new UserProfile();
            string Password = "password";

            //act
            _up.Password = Password;

            //assert
            Assert.NotNull(_up.Password);
            Assert.Equal(_up.Password, Password);

        }

        [Fact]
        public void Test13()
        {
            //Arrange
            Customer _custTest = new Customer();
            string Address = "test street";

            //act
            _custTest.Address = Address;

            //assert
            Assert.NotNull(_custTest.Address);
            Assert.Equal(_custTest.Address, Address);
        }

        [Fact]
        public void Test14()
        {
            //Arrange
            Customer _custTest = new Customer();
            string Email = "test@email.com";

            //act
            _custTest.Email = Email;

            //assert
            Assert.NotNull(_custTest.Email);
            Assert.Equal(_custTest.Email, Email);
        }

        [Fact]
        public void Test15()
        {
            LineItems _quanTest = new LineItems();
            int ItemId = 1;

            //act
            _quanTest.ItemId = ItemId;

            //assert
            //Assert.NotNull(_quanTest.ItemId);
            Assert.Equal(_quanTest.ItemId, ItemId);
        }
        [Fact]
        public void Test16()
        {
            Products _prodTest = new Products();
            int ProdId = 1;

            //act
            _prodTest.ProdId = ProdId;

            //assert
           // Assert.NotNull(_prodTest.ProdId);
            Assert.Equal(_prodTest.ProdId, ProdId);

        }

        [Fact]
        public void Test17()
        {
            Products _prodTest = new Products();
            string Name = "test";

            //act
            _prodTest.Name = Name;

            //assert
            Assert.NotNull(_prodTest.Name);
            Assert.Equal(_prodTest.Name, Name);

        }

        [Fact]
        public void Test18()
        {
            //Arrange
            Orders _orderTest = new Orders();
            int OrderId = 1;

            //act
            _orderTest.OrderId = OrderId;

            //assert
            //Assert.NotNull(_orderTest.OrderId);
            Assert.Equal(_orderTest.OrderId, OrderId);
        }

        [Fact]
        public void Test19()
        {
            //Arrange
            Orders _orderTest = new Orders();
            int Total = 100;

            //act
            _orderTest.Total = Total;

            //assert
            //Assert.NotNull(_orderTest.OrderId);
            Assert.Equal(_orderTest.Total, Total);
        }

        [Fact]
        public void Test20()
        {
            //Arrange
            Orders _orderTest = new Orders();
            int prodId = 1;

            //act
            _orderTest.prodId = prodId;

            //assert
            //Assert.NotNull(_orderTest.OrderId);
            Assert.Equal(_orderTest.prodId, prodId);
        }

    }
}
