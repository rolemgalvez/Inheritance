using System;
using System.Collections.Generic;

namespace HomeworkTwentyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Vehicle());
            vehicles.Add(new Car());
            vehicles.Add(new Boat());
            vehicles.Add(new Motorcycle());

            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car car)
                {
                    car.NumberOfDoors = 4;
                }

                if (vehicle is Boat boat)
                {
                    boat.NumberOfOars = 2;
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
