using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class WhiteTiger : Tiger, IMonochrome
    {
        public string EyeColor { get; set; } = "Blue";

        public string BlackOrWhite()
        {
            return "Why not Both?";
        }

        public override string HasCereal()
        {
            return "Not me!";
        }

    }
}
