using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Opah : Bony
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public virtual string FlapFins()
        {
            return "metabolism, movement, and reaction speed increased";
        }
    }
}
