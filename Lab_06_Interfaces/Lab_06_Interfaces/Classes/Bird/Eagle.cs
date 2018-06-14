using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Bird
{
    class Eagle : Flying
    {
        public bool IsEndangered { get; set; } = true;
        public bool IsAmericanSymbolForFreedo { get; set; } = true;

        public override string Sound()
        {
            return "Screech!";
        }
    }
}
