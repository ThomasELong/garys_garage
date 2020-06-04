using System;

namespace garys_garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void FillGasTank()
        {
            
        }

        public override void Drive()
        {
            Console.WriteLine("Ruuumble!");
        }
    }
}