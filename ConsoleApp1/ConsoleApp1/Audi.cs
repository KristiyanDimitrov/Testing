﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTesting
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

        public new void ShowDetails() // New hides the method of the base class
        {
            Console.WriteLine("This Audi has {0} HP and its color is {1}. Model is {2}", this.HP, this.Color, this.Model);
        }

        public override void RepairCar() // Override creates a version of the base function for this class
        {
            Console.WriteLine("{0} {1} Is repaired!", Audi.brand, this.Model);

        }
    }
}
