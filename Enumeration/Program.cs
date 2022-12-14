using System;

namespace AlgoSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Planets.Pluto + " is a planet");
            Console.WriteLine(Planets.Earth + " is planet #" + (int)Planets.Earth);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius + "km");
            Console.WriteLine("volume: " + volume + "km3");
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum Planets
    {
        Mercury =1, 
        Venus =2, 
        Earth =3, 
        Mars =4, 
        Jupiter =5, 
        Saturn =6, 
        Uranus =7, 
        Neptune =8, 
        Pluto =9
    }
    enum PlanetRadius
    {
        Mercury = 2349,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}