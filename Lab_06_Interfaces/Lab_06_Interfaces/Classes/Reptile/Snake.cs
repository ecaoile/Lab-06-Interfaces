using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    public abstract class Snake : Reptile
    {
        public override bool HasLegs { get; set; } = false;
    }
}
