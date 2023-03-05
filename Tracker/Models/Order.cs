using System;
using System.Collections.Generic;
namespace Tracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {} ;
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Today { get; }

    public Order(string title, string description, int price)
    {
      _instances.Add(this);
      Title = title;
      Description = description;
      Price = price;
      Today = DateTime.Today;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}