using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    class WhiteTiger : Tiger
    {
        public string EyeColor { get; set; } = "Blue";

        public override string HasCereal()
        {
            return "Not me!";
        }

    }
}
