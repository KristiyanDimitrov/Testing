using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTesting
{
    // sealed class M3:BMW
    sealed class M3 :BMW
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
