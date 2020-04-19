using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
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

        protected int HP { get; set; }
        protected string Color { get; set; }
    }
}
