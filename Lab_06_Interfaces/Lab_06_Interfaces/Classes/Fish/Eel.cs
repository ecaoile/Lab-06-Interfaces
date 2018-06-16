using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Fish
{
    public class Eel : Bony, ISwim
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public bool IsNocturnal { get; set; } = true;
        public bool CanBreatheUnderwater { get; set; } = true;
        public string SwimSpeed { get; set; } = "15 mph";

        public override string Sushify()
        {
            return "yummy";
        }

        public string Electrocute()
        {
            return "Zzzzt!";
        }

        public string Swim()
        {
            return "swimming";
        }
    }
}
