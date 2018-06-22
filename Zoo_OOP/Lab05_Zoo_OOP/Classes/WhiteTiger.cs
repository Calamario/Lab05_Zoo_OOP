using Lab05_Zoo_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public class WhiteTiger : Tiger
    {
        public string EyeColor { get; set; } = "Blue";

        public string BlackOrWhite()
        {
            return "Why Not Both?";
        }

        public override string HasCereal()
        {
            return "Not me!";
        }

    }
}
