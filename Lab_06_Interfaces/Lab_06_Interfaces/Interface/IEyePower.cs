using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Interface
{
    interface IEyePower
    {
        bool CanDetectInfrared { get; set; }
        bool CanZoomFar { get; set; }
        bool CanSeeInTheDark { get; set; }
    }
}
