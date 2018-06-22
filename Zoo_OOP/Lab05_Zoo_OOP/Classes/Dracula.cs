using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Dracula : Bats
    {
        //overides the abstract method
        public override string EatsWhat()
        {
            return "Human Blood";
        }

        //overirdes abtract method that was previously defined
        public override string LiveWith()
        {
            return "Alone";
        }
    }
}
