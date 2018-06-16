using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Bird
{
    public class Penguin : NonFlying, ISwim
    {
        public bool IsCounterShaded { get; set; } = true;
        public override bool HasWings { get; set; } = false;
        public bool CanBreatheUnderwater { get; set; } = false;
        public string SwimSpeed { get; set; } = "20 mph";

        public string BellyFlop()
        {
            return "thump";
        }

        public string Swim()
        {
            return "swimming";
        }

    }
}
