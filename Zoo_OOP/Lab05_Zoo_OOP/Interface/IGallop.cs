using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_Zoo_OOP.Interface
{
    interface IGallop
    {
        bool FasterThanWalking { get; set; }

        bool MoreMagesticThanRunning { get; set; }

        string WalkOrRun();
    }
}
