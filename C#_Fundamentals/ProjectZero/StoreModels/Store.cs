using System;
using System.Text.RegularExpressions;

namespace StoreModels
{
    public class Store
    {
        //This is a field
        private string _city;

        //This is a property that uses the field called _city
        public string City
        {
            get { return _city; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("City can only hold letters!");
                }
                _city = value;
            }
        }

        public string State { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nState: {State}";
        }

    }

    public class Customer {
        //TODO properties: name, address, email/phone, list of orders
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nEmail: {Email}\nCustomer Id: {CustId}";
        }


    }

    public class StoreFront {
        //TODO properties: name, address, list of Products, List of orders
        public string Name { get; set; }
        public string Address { get; set; }
        public int StoreId { get; set; }
        public int? OrderId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nStore Id: {StoreId}";
        }
    }

    public class Orders {
        //TODO properties: List of line items, Storefronts location (that the order was placed), total price
        public int OrderId { get; set; }
        public int? Total { get; set; }
        public int? CustId { get; set; }
        public int? StoreId { get; set; }
        public int? prodId {get; set;}

        public override string ToString()
        {
            return $"Order Id: {OrderId}\nStore Id: {StoreId}\nCust Id: {CustId}\nProduct ID: {prodId}\nTotal: {Total}";
        }
    }

    public class LineItems {
        //TODO properties: product, quantity
        public int ItemId {get; set;}
        public int? Quantity { get; set; }

        public override string ToString()
        {
            return $"Quantity: {Quantity}\nItemId: {ItemId}";
        }
    }

    public class Products {
        //TODO properties: name, price, desc (optional), category (optional)
        public int ProdId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? StoreId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nProduct Id: {ProdId}\nStore ID {StoreId}";
            //n==ItemId: {ItemId}\nStoreId: {StoreId}";
        }


    }

    public class Singleton {
        public static StoreFront viewStoreFront;
        public static Customer viewCustomer;
    }


    public class QuantityModel
    {
        //TODO properties: name, price, desc (optional), category (optional)
        public int ProdId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? StoreId { get; set; }
        public int? Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nProduct Id: {ProdId}\nStore ID {StoreId}\nQuantity: {Quantity}";
            //n==ItemId: {ItemId}\nStoreId: {StoreId}";
        }


    }

}