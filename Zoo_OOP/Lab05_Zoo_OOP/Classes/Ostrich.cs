﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class Ostrich : PlainAnimal
    {
        public override bool HasStripes { get; set; }
        public override int NumOfLegs { get; set => throw new NotImplementedException(); }

        public override string EatsWhat()
        {
            return "Bugs and Grass";
        }
    }
}