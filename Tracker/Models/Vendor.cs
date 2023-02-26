using System.Collections.Generic;

namespace Tracker.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private static List<Vendor> _instances = new List<Vendor> { };


        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}