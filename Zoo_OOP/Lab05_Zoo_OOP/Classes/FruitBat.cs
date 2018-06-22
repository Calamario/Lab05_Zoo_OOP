using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class FruitBat : Bats
    {
        // overide the abstract method
        public override string EatsWhat()
        {
            return "Fruits";
        }
    }
}
