using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Interface
{
    interface IEyePower
    {
        bool CanDetectInfrared { get; set; }
        bool CanSeeFar { get; set; }
        bool CanSeeInTheDark { get; set; }
    }
}
