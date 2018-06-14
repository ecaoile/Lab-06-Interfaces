using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    class Chameleon : Reptile
    {
        public override bool HasTeeth { get; set; } = true;

        public string ColorChange(string backgroundColor)
        {
            return backgroundColor;
        }
    }
}
