using System.Collections.Generic;

namespace Bakery.Models
{

    public class Vendors
  {
    public string VendorName { get; set; }
    public int Volume { get; set; }
    public int Cost { get; set; }

    private static List<Vendors> _Vendor = new List<Vendors> {};

    public Vendors (string VendorName)
    {
      
      _Vendor.Add(this);
    }

    public static List<Vendors> GetAll()
    {
      return _Vendor;
    }

    public static void ClearAll()
    {
      _Vendor.Clear();
    }

  }
}