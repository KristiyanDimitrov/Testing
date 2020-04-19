using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(220, "red", "M3")
            };

            foreach (var Car in cars)
            {
                Car.ShowDetails();
                Car.RepairCar();
            }

            Car bmwZ3 = new BMW(200, "green", "Z3");
            Car audiA3 = new BMW(200, "yellow", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carb = (Car)bmwM5;
            carb.ShowDetails();


            Console.ReadKey();
            
        }
    }
}
