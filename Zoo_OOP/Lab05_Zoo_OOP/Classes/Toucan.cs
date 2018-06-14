using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Toucan : JungleAnimal
    {
        public override bool HasStripes { get; set; } = false;

        public override int NumOfLegs { get; set; } = 2;

        public override string HasCereal()
        {
            string colorful = "Frooooty Loops";
            return colorful;
        }

        public override string EatsWhat()
        {
            return "Fruits!";
        }

        public override string LiveWith()
        {
            return "Flock";
        }
    }
}
