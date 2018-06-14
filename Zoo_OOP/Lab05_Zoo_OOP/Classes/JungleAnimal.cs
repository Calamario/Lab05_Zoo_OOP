using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class JungleAnimal : Animal
    {
        public override bool LovesTrees { get; set; } = true;

        abstract public bool HasStripes { get; set; }
    }
}
