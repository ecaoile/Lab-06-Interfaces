using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    class Python : Snake
    {
        public override bool HasTeeth { get; set; } = true;
        public virtual bool HasFangs { get; set; } = false;

        public string Code()
        {
            return "Code.py";
        }
    }
}
