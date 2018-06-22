using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Ostrich : PlainAnimal
    {
        // overide the abstract prop
        public override bool HasStripes { get; set; } = false;
        // overide the abstract prop
        public override int NumOfLegs { get; set; } = 2;

        // overide the abstract method
        public override string EatsWhat()
        {
            return "Bugs and Grass";
        }
    }
}
