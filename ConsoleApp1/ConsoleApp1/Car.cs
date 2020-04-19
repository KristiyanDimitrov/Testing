using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The Car has an ID of {0} and it's owned by {1}",carIDInfo.IDNum, carIDInfo.Owner );
        }

        public Car (int HP, string color)
        {
            this.HP = HP;
            this.Color = color;
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
