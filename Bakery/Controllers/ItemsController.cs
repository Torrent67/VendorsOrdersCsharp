using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Vendors> allItems = Vendors.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm(string vendorName)
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string vendorName)
    {
      Vendors myItem = new Vendors(vendorName);
      return RedirectToAction("Index");
    }

  }
}