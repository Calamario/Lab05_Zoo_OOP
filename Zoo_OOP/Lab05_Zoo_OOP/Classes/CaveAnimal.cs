using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    abstract class CaveAnimal : Animal
    {
        public override string SleepAt()
        {
            return "AM";
        }

    }
}
