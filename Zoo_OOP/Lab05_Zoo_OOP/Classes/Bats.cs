using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class Bats : CaveAnimal, IFly
    {
        public override int NumOfLegs { get; set; } = 2;

        public bool DoIHasWing { get; set; } = true;

        public string HowIFly()
        {
            return "In The darkness";
        }

        public override string LiveWith()
        {
            return "Colony";
        }
    }
}
