using System.Collections.Generic;
using CityMang.Models;

namespace CityMang
{
    // public class cityVariable
    // {
    //     City currentCity = new City();
    // }
    public class City
    {
        public string Name {get;set;}
        public City(string name)
        {
            Name = name;
            Dictionary<string,int> resources = myCity;
        }
        public static Dictionary<string,int> myCity = new Dictionary<string, int>() {{"Cash", 1000},{"Food", 100},{"Metal", 10},{"Wood", 10},{"Farms", 1},{"Mines", 1},{"Housing", 1},{"Market", 1},{"Sawmills", 1}};
    
        public static int resourceProduction(int owned, Building building)
        {
            return owned * building.gain;
        }
        public void constructBuilding(int farmUp, int marketUp, int mineUp, int sawmillUp, int houseUp) 
        {
            myCity["Farms"] += farmUp;
            myCity["Mines"] += mineUp;
            myCity["Housing"] += houseUp;
            myCity["Market"] += marketUp;
            myCity["Sawmills"] += sawmillUp;
        }
    }
    public class Population
    {
        public int popTotal { get; set; }

        public Population(int Pop)
        {
            this.popTotal = Pop;
        }
    }


}



