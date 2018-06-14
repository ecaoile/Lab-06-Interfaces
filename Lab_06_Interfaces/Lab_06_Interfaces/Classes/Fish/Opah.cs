using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Opah : Bony, ISwim
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public string SwimSpeed { get; set; } = "45 mph";
        public bool CanBreatheUnderwater { get; set; } = true;
        public virtual string FlapFins()
        {
            return "metabolism, movement, and reaction speed increased";
        }
    }
}
