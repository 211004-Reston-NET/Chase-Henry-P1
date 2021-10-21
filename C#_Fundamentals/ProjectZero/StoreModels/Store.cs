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
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ListOfOrders { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nEmail: {Email}\nListOfOrders: {ListOfOrders}";
        }


    }

    public class StoreFront {
        //TODO properties: name, address, list of Products, List of orders
        public string Name { get; set; }
        public string Address { get; set; }
        public string ListOfProducts { get; set; }
        public string ListOfOrders { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nListOfProducts: {ListOfProducts}\nListOfOrders: {ListOfOrders}";
        }
    }

    public class Orders {
        //TODO properties: List of line items, Storefronts location (that the order was placed), total price
        public string ListOfLineItems { get; set; }
        public string StoreFrontAddress { get; set; }
        public string Total { get; set; }

        public override string ToString()
        {
            return $"ListOfLineitems: {ListOfLineItems}\nSStoreFrontAddress: {StoreFrontAddress}\nTotal: {Total}";
        }
    }

    public class LineItems {
        //TODO properties: product, quantity
        public string Product { get; set; }
        public string Quantity { get; set; }

        public override string ToString()
        {
            return $"Product: {Product}\nQuantity: {Quantity}";
        }
    }

    public class Products {
        //TODO properties: name, price, desc (optional), category (optional)
        public string Name { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}";
        }
    }
}