using System;
using System.Collections.Generic;
using System.Text;


namespace OOPTesting
{
    public interface iCar // Access modifier on interface applies to all interface access modiers
    {
        void ShowDetails();
        void RepairCar();

    }


    partial class  Car : Vehicle, iCar
    {
        protected override int HP { get; set; }
        protected override string Color { get; set; }
        private static List<Car> CarCatalog = new List<Car>();

        public static IEnumerable<Car> GetCatalog()
        {
            foreach(Car Car in CarCatalog)
            {
                yield return Car;
            }
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine("The Car has an ID of {0} and it's owned by {1}",carIDInfo.IDNum, carIDInfo.Owner );
        }

        public Car (int HP, string color)
        {
            this.HP = HP;
            this.Color = color;
            CarCatalog.Add(this);
        }
        public Car()
        {
            this.HP = 0;
            this.Color = "none";
        }

        public void ShowDetails()
        {
            Console.WriteLine("This car has {0} HP and its color is {1}", this.HP, this.Color);
        }

        public virtual void RepairCar()
        {
            Console.WriteLine("Car Is repaired!");
        }

        
    }
}
