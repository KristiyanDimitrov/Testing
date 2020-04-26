using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTesting
{
    abstract class Vehicle
    {
        abstract protected int HP { get; set; }
        abstract protected string Color { get; set; }
    }
}
