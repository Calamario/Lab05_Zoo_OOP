using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Zebra : PlainAnimal, IGallop
    {
        public override bool HasStripes { get; set; } = true;

        public override int NumOfLegs { get; set; } = 4;

        public bool FasterThanWalking { get; set; } = true;

        public bool MoreMagesticThanRunning { get; set; } = true;

        public string BlackOrWhite()
        {
            return "Why Not Both?";
        }

        public override string EatsWhat()
        {
            return "Grass";
        }

        public string WalkOrRun()
        {
            return "Galloping All the Way";
        }
    }
}
