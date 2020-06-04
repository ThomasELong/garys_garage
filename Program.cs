using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna P12 = new Cessna()
            {
            Color = "White"
            };

            Tesla ModelS = new Tesla()
            {
            Color = "Purple"
            };

            Ram Dually = new Ram()
            {
            Color = "Black"
            };

        
        
        Console.Write($"The {P12.Color} P12 is flying a little low... ");
        P12.Drive();
        Console.WriteLine($"It makes a sharp {P12.Turn()} hand turn and nosedives!");


        Console.Write($"The {ModelS.Color} Tesla coming cruising by! ");
        ModelS.Drive();

        Console.Write($"The overcompensating {Dually.Color} Ram Dually is having a hard time starting... ");
        Dually.Drive();



        }
    }
}
