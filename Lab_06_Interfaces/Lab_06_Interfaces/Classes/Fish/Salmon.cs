using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    class Salmon : Bony
    {
        public override bool IsWarmBlooded { get; set; } = false;

        public override string Sushify()
        {
            return "yummy";
        }
    }
}
