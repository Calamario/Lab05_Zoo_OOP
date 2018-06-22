using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class JungleAnimal : Animal
    {
        // overide the virtual prop
        public override bool LovesTrees { get; set; } = true;

        //new abstract prop
        abstract public bool HasStripes { get; set; }
    }
}
