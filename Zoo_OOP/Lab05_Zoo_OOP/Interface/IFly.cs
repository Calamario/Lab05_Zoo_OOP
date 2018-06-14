using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    interface IFly
    {
        bool DoIHasWing { get; set; }

        string HowIFly();
    }
}
