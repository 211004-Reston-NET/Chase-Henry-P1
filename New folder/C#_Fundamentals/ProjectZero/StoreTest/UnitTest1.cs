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
            Assert.NotNull(_orderTest.OrderId);
            Assert.Equal(_orderTest.OrderId, OrderId);
        }

        [Fact]
        public void Test3(){
            Products _prodTest = new Products();
            int ProdId = 1;

            //act
            _prodTest.ProdId = ProdId;

            //assert
            Assert.NotNull(_prodTest.ProdId);
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
            Assert.NotNull(_liTest.ItemId);
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
    }
}
