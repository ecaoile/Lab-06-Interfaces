using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    class Ostrich : NonFlying
    {
        public override bool HasWings { get; set; } = false;
    }
}
