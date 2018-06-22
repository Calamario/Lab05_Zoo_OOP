using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class ForestAnimal : Animal
    {
        // overrode the virtual prop
        public override bool LovesTrees { get; set; } = true;

        // overide the abstract prop
        public override int NumOfLegs { get; set; } = 4;

        // overide the abstract method
        public override string EatsWhat()
        {
            return "Carrots";
        }

        // overide the abstract method
        public override string LiveWith()
        {
            return "Herd";
        }
    }
}
