using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    abstract class ForestAnimal : Animal
    {
        public override bool LovesTrees { get; set; } = true;

        public override int NumOfLegs { get; set; } = 4;

        public override string EatsWhat()
        {
            return "Carrots";
        }

        public override string LiveWith()
        {
            return "Herd";
        }
    }
}
