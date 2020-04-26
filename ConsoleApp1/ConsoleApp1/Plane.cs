using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTesting
{
    class Plane
    {
        public int NumberOfSeats { get; set; }
        public string Name { get; set; }

        public Plane (string name, int numberOfSeats)
        {
            this.Name = name;
            this.NumberOfSeats = numberOfSeats;
        }
    }
}
