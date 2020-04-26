using System;
using System.Collections.Generic;

namespace OOPTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car justCar = new Car();

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

            //  checking object type

            foreach (object Vehicle in Car.GetCatalog())
            {
                string originalType = Vehicle.GetType().ToString();
                Console.WriteLine(originalType);

                try
                {
                    object TestObject = new Plane("Deffo not a Car", 700);
                    Car TestCarObject = (Car)TestObject;
                }
                catch { Console.WriteLine("Can't convert object"); }
                   
                Car TestCar = (Car)Vehicle; // ````````NOT SAFE!````````````` How to make it Safe? 


                TestCar.ShowDetails(); // Audi hides the bse method of car but if you cast it as Car you can use it again.

                BMW TestBMW = Vehicle as BMW; // Retrun null if object is not a BMW. Can use to make cast SAFE.
                if (TestBMW == null)
                {
                    Console.WriteLine("This is not a BMW");
                }

                if (TestBMW is BMW)
                {
                    Console.WriteLine("This is a BMW");
                }



               
                
            }

            

            Console.ReadKey();
            
        }
    }
}
