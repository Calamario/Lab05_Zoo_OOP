using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    abstract class Bats : CaveAnimal
    {
        public override int NumOfLegs { get; set; } = 2;

        public override string LiveWith()
        {
            return "Colony";
        }
    }
}
