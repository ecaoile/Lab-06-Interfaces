using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    abstract class Flying : Bird
    {
        public override bool CanFly { get; set; } = true;
        public override bool HasWings { get; set; } = true;
    }
}
