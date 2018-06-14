using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class PlainAnimal : Animal
    {
        public abstract bool HasStripes { get; set; }

        public override string LiveWith()
        {
            return "Herd";
        }
    }
}
