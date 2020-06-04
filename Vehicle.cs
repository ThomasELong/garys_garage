using System;

namespace garys_garage
{
    public class Vehicle
    {
        public string MainColor{ get; set; }
        public string MaximumOccupancy { get; set; }
        public string Color { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
        public virtual string Turn()
        {
            return("right");
        }
        public virtual string Stop()
        {
           return("stop");
               
        }
    }
}