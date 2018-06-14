using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Deer : ForestAnimal, IGallop
    {
        public bool HasHorns { get; set; } = true;

        public bool FasterThanWalking { get; set; } = true;
        public bool MoreMagesticThanRunning { get; set; } = true;

        public string WalkOrRun()
        {
            return "Gallop Gallop";
        }
    }
}
