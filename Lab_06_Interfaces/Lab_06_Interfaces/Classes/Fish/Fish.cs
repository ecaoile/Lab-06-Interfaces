using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    abstract class Fish : Animal 
    {
        public virtual bool HasScales { get; set; } = true;
        public virtual bool HasGills { get; set; } = true;
        public virtual bool HasSwimBladder { get; set; } = true;
        public override bool HasTeeth { get; set; } = true;
        public abstract bool HasBones { get; set; }
        public virtual string Sushify()
        {
            return "yucky";
        }
    }
}
