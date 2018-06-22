using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class Deer : ForestAnimal, IGallop
    {
        //Assigns a new property
        public bool HasHorns { get; set; } = true;

        //Inteface prop
        public bool FasterThanWalking { get; set; } = true;
        //Interface prop
        public bool MoreMagesticThanRunning { get; set; } = true;
        //Interface method
        public string WalkOrRun()
        {
            return "Gallop Gallop";
        }
    }
}
