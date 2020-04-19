using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Audi : Car
    {
        private const string brand = "Audi";
        private string model;
        public string Model { get { return model; } set { model = value ?? ""; } }

        public Audi(int HP, string color, string model) : base(HP, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("This car has {0} HP and its color is {1}. Model is {2}", this.HP, this.Color, this.Model);
        }

        public override void RepairCar()
        {
            Console.WriteLine("{0} {1} Is repaired!", Audi.brand, this.Model);

        }
    }
}
