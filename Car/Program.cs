using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);

            //car.Drive(400);
            //Console.WriteLine("fuel: " + car.GasTankLevel);
            //Console.WriteLine("od: " + car.Odometer);
            //Console.ReadLine();
        }
    }
}
