using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Reptile
{
    public class Crocodile : Reptile
    {
        public override bool HasTeeth { get; set; } = true;

        public override string Sound()
        {
            return "CHOMP!";
        }
    }
}
