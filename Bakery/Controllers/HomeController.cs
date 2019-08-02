using Microsoft.AspNetCore.Mvc;
using CityMang.Models;

namespace  CityMang.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      
    }
}