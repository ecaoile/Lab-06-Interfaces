using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Shark : Cartilaginous
    {
        public override bool IsWarmBlooded { get; set; } = false;

        public string FlipMeOver()
        {
            return "RIP";
        }
    }
}
