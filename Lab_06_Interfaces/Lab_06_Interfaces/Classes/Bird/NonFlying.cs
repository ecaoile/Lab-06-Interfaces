using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    public abstract class NonFlying : Bird
    {
        public override bool CanFly { get; set; } = false;
    }
}
