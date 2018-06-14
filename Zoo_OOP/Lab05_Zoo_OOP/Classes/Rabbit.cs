using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Rabbit : ForestAnimal
    {
        public override string HasCereal()
        {
            return "Silly Rabbit, Trix are for kids";
        }

        public override string SleepAt()
        {
            return "AM";
        }
    }
}
