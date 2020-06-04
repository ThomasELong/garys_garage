using System;

namespace garys_garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void FillGasTank()
        {    }

        public override void Drive()
        { Console.WriteLine("Zooom!"); }
        public override string Turn()
        { return("left"); }
    }
}