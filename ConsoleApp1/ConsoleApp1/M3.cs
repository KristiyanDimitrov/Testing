using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // sealed class M3:BMW
    class M3 :BMW
    {
        public M3 (int HP, string color, string model) : base(HP, color, model)
        {

        }


        /* Can't override as it is sealed. If you seal a class you can prevent inheritance
        public override void RepairCar()
        {
            base.RepairCar();
        }
        */
    }
}
