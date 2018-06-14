using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Ostrich : PlainAnimal
    {
        public override bool HasStripes { get; set; } = false;
        public override int NumOfLegs { get; set; } = 2;

        public override string EatsWhat()
        {
            return "Bugs and Grass";
        }
    }
}
