using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    abstract class Mammal : Animal
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public override bool HasTeeth { get; set; } = true;
        public virtual bool HasMammaryGlands { get; set; } = true;
        public virtual bool CanPet { get; set; } = true;
        public virtual int NumOfLives { get; set; } = 1;
    }
}
