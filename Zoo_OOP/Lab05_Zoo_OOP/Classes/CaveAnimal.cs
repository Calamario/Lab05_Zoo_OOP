using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class CaveAnimal : Animal
    {
        //Overrode the SleepAt virtual method. 
        public override string SleepAt()
        {
            return "AM";
        }

    }
}
