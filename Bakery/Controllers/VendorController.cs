using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
   public class VendorsController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor newVendor = new Vendor(vendorName,vendorDesc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", vendorOrder);
      return View(model);
    }


    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string NewOrder, string orderDesc, int price, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(NewOrder, orderDesc, price, orderDate);
      foundVendor.AddItem(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("order", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}