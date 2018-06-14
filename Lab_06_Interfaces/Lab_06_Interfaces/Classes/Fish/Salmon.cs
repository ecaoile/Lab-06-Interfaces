using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Salmon : Bony, ISwim, IEyePower
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public bool CanBreatheUnderwater { get; set; } = true;
        public string SwimSpeed { get; set; } = "20 mph";
        public bool CanDetectInfrared { get; set; } = true;
        public bool CanZoomFar { get; set; } = false;
        public bool CanSeeInTheDark { get; set; } = false;

        public override string Sushify()
        {
            return "yummy";
        }
    }
}
