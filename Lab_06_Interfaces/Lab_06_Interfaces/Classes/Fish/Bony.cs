using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Fish
{
    public abstract class Bony : Fish
    {
        public override bool HasBones { get; set; } = true;
    }
}
