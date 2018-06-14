using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    class Penguin : NonFlying
    {
        public bool IsCounterShaded { get; set; } = true;
        public override bool HasWings { get; set; } = false;

        public string BellyFlop()
        {
            return "thump";
        }
     
    }
}
