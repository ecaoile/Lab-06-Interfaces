using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    abstract class Lizard : Reptile
    {
        public override bool HasLegs { get; set; } = true;
    }
}
