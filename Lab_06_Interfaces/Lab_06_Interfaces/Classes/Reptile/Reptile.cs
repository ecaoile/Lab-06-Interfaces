using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    public abstract class Reptile : Animal
    {
        public bool HasVertebrae { get; set; } = true;
        public override bool IsWarmBlooded { get; set; } = false;
        public virtual bool HasLegs { get; set; } = true;
    }
}
