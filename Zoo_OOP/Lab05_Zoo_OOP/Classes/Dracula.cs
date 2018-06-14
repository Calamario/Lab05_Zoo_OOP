using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Dracula : Bats
    {
        public override string EatsWhat()
        {
            return "Human Blood";
        }

        public override string LiveWith()
        {
            return "Alone";
        }
    }
}
