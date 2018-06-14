using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Shark : Cartilaginous, ISwim
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public string SwimSpeed { get; set; } = "30 mph";
        public bool CanBreatheUnderwater { get; set; } = true;
        public string FlipMeOver()
        {
            return "RIP";
        }
    }
}
