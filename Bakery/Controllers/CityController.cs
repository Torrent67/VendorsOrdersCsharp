using Microsoft.AspNetCore.Mvc;
using CityMang.Models;
using CityMang;
using System.Collections.Generic;

namespace CityMang.Controllers
{
  public class CityController : Controller
  {
    City currentCity = new City("cityName");

    [HttpPost("/city/myCity")]
      public ActionResult myCity(string cityName)
      {
        currentCity.Name = cityName;
        return View(currentCity);
      }
    [HttpGet("/city/BuildMenu")]
      public ActionResult BuildMenu()
      {
        return View();
      }
    [HttpPatch("/city/myCity{updated}")]
      public ActionResult myCity(int farmUp, int marketUp, int mineUp, int sawmillUp, int houseUp)
      { 
        currentCity.constructBuilding(farmUp, marketUp, mineUp, sawmillUp, houseUp);

        return View(currentCity);
      }

  }
}