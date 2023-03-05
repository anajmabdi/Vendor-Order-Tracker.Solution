using System.Collections.Generic;

namespace Tracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private static List<Vendor> _instances = new List<Vendor> { };
        public List<Order> Orders { get; set; }
        public int Id { get; }

        public Vendor(string name, string description)
        {
            _instances.Add(this);
            Name = name;
            Description = description;
            Id = _instances.Count;
            Orders = new List<Order>{};
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}