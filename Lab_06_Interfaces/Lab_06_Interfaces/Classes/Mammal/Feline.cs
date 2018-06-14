using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    abstract class Feline : Mammal
    {
        public virtual bool IsSassy { get; set; } = true;
        public override int NumOfLives { get; set; } = 9;
        public abstract bool AvoidHumans { get; set; }
    }
}
