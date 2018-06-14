using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Interface
{
    interface ISwim
    {
        string SwimSpeed { get; set; }
        bool CanBreathUnderWater { get; set; }
    }
}
