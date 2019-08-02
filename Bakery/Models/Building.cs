using System;
using System.Collections.Generic;

namespace CityMang.Models
{
    public abstract class Building
    {
        public int moneyCost { get; set; }
        public int resourceCost { get; set; }
        public int gain { get; set; }
        public Building(int MoneyCost, int resourceCost)
        {
            this.moneyCost = MoneyCost;
            this.resourceCost = resourceCost;
            this.gain = 0;
        }
    }
    //constructor for housing 
    public class House : Building
    {
        private int PopCap;
        public House(int moneyCost, int resourceCost)
            : base(moneyCost, resourceCost)
        {
            this.PopCap = 10;
        }
    }
    //constructor for money production
    public class Commercial : Building
    {
        public Commercial(int moneyCost, int resourceCost)
            : base(moneyCost, resourceCost)
        {
            this.gain = 100;
        }
    }
    //constructors for production
    public class Farm : Building
    {
        public Farm(int moneyCost, int resourceCost)
            : base(moneyCost, resourceCost)
        {
            this.gain = 100;
        }
    }

    public class Mine : Building
    {
        public Mine(int moneyCost, int resourceCost)
            : base(moneyCost, resourceCost)
        {
            this.gain = 10;
        }
    }

    public class SawMill : Building
    {
        public SawMill(int moneyCost, int resourceCost)
            : base(moneyCost, resourceCost)
        {
            this.gain = 10;
        }
    }

}