using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Bird
{
    public class Eagle : Flying, IEyePower
    {
        public bool IsAmericanSymbolForFreedo { get; set; } = true;
        public bool CanDetectInfrared { get; set; } = false;
        public bool CanSeeFar { get; set; } = true;
        public bool CanSeeInTheDark { get; set; } = false;

        public override string Sound()
        {
            return "Screech!";
        }
    }
}
