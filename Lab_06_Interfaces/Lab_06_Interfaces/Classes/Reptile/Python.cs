using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Reptile
{
    class Python : Snake, IEyePower
    {
        public override bool HasTeeth { get; set; } = true;
        public virtual bool HasFangs { get; set; } = false;
        public bool CanDetectInfrared { get; set; } = true;
        public bool CanSeeInTheDark { get; set; } = false;
        public bool CanZoomFar { get; set; } = false;

        public string Code()
        {
            return "Code.py";
        }
    }
}
