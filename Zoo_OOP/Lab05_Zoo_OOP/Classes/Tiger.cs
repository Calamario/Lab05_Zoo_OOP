using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Tiger : JungleAnimal
    {
        public override int NumOfLegs { get; set; } = 4;

        public override bool HasStripes { get; set; } = true;

        public override string SleepAt()
        {
            return "AM";
        }

        public override string HasCereal()
        {
            string type = "Frosted Flakes";
            string comment = "They're Great!";
            return $"{type} {comment}";
        }

        public override string EatsWhat()
        {
            return "MEAT";
        }

        public override string LiveWith()
        {
            return "Solitary";
        }
    }
}
