using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    class Owl : Flying
    {
        public virtual bool IsNocturnal { get; set; } = true;

        public string BinocularVision()
        {
            return "O_O";
        }
    }
}
