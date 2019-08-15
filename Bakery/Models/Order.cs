using System.Collections.Generic;
using System;

namespace Bakery.Models
{
    public class Order
    {
        public string newOrder { get; set;}
        public string orderDesc { get; set;}
        public int price { get; set;}
        public string orderDate { get; set;}
        public int Id { get;}
        private static List<Order> _instances = new List<Order> { };

        public Order(string NewOrder, string Description, int Price, string date)
        {
            newOrder = NewOrder;
            orderDesc = Description;
            price = Price;
            orderDate = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}