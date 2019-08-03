using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instance = new List<Vendor> {};
    public string userInput { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string Vendor, string vendorDesc)
    {
      userInput = Vendor;
      Description = vendorDesc;
      _instance.Add(this);
      Id = _instance.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instance.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instance;
    }

    public static Vendor Find(int searchId)
    {
      return _instance[searchId-1];
    }

    public void AddItem(Order order)
    {
      Orders.Add(order);
    }
  }

}