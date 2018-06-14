using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Reindeer : Deer, IFly, IGallop
    {
        public bool DoIHasWing { get; set; } = false;

        public bool FasterThanWalking { get; set; } = true;

        public bool MoreMagesticThanRunning { get; set; } = true;

        public string HowIFly()
        {
            return "Magical Powers";
        }

        public string WalkOrRun()
        {
            return "Galloping Duh";
        }
    }
}
