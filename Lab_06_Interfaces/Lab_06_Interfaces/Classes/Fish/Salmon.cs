using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Salmon : Bony
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public bool CanBreatheUnderwater { get; set; } = true;
        public string SwimSpeed { get; set; } = "20 mph";

        public override string Sushify()
        {
            return "yummy";
        }
    }
}
