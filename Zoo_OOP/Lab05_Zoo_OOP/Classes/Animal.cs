using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    public abstract class Animal
    {
        //abstract method must be overridden before the first concrete class
        public abstract int NumOfLegs { get; set; }

        //virtual class, CAN be overridden
        public virtual bool HasTail { get; set; } = true;

        public virtual bool LovesTrees { get; set; } = false;

        public abstract string EatsWhat();

        public abstract string LiveWith();

        public virtual string HasCereal()
        {
            return "none";
        }

        public virtual string SleepAt()
        {
            return "PM";
        }
    }
}
