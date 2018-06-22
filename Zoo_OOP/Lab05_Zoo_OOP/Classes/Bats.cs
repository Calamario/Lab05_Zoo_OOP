using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class Bats : CaveAnimal, IFly
    {
        //Overrides an abstract property
        public override int NumOfLegs { get; set; } = 2;

        //Property implemented from IFly interface
        public bool DoIHasWing { get; set; } = true;

        //Method implemented from interface
        public string HowIFly()
        {
            return "In The darkness";
        }
        
        //Abstract method overridden
        public override string LiveWith()
        {
            return "Colony";
        }
    }
}
