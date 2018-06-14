using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Classes
{
    abstract class Animal
    {
        public abstract int NumOfLegs { get; set; }

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
