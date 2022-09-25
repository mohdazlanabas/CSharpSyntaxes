namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();
            // Vehicle vehicle = new Vehicle();
        }
        abstract class Vehicle
        {
            public int speed = 0;
            public void go()
            {
                Console.WriteLine( "The Vehicle is Missing!" );
            }

        }
        class Car : Vehicle
        {
            public int wheels = 4;
            public int maxSpeed = 200;
        }
        class Bicycle : Vehicle
        {
            public int wheels = 2;
            public int maxSpeed = 100;
        }
        class Boat: Vehicle
        {
            public int wheels = 0;
            public int maxSpeed = 50;
        }
    }
}