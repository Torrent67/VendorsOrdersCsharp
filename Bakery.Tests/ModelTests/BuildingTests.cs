using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityMang;
using CityMang.Models;
using System;

namespace BuildingTests
{
    [TestClass]
    public class BuildingTester
    {
        [TestMethod]
        public void HouseConstructor_BuildAHouse_House()
        {
            House myHome = new House(20,10);
            Console.WriteLine(myHome);
            Console.WriteLine(myHome.moneyCost);
            Assert.AreEqual(20,myHome.moneyCost);
        }

        
    }
}