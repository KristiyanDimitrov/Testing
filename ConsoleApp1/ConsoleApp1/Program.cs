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

            // Relationship
            audiA3.SetCarIDInfo(1, "Kris");
            audiA3.GetCarIDInfo();


            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            // Inherited relationship
            bmwM5.SetCarIDInfo(2, "Kris");
            bmwM5.GetCarIDInfo();
            

            Car carb = (Car)bmwM5;
            carb.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 mod");
            myM3.RepairCar();

            Console.ReadKey();
            
        }
    }
}
