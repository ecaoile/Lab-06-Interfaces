using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    abstract class Bird : Animal
    {
        public abstract bool CanFly { get; set; }
        public bool HasFeathers { get; set; } = true;
        public override bool HasTeeth { get; set; } = true;
        public abstract bool HasWings { get; set; }
        public virtual bool HasBeak { get; set; } = true;
        public override bool IsWarmBlooded { get; set; } = true;
    }
}
