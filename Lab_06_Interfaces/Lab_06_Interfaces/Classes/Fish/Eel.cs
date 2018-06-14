using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Eel : Cartilaginous
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public bool IsNocturnal { get; set; } = true;

        public override string Sushify()
        {
            return "yummy";
        }
    }
}
