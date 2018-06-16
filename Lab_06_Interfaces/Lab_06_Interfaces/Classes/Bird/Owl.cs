using System;
using System.Collections.Generic;
using System.Text;
using Lab_06_Interfaces.Interface;

namespace Lab_06_Interfaces.Classes.Bird
{
    public class Owl : Flying, IEyePower
    {
        public bool IsNocturnal { get; set; } = true;
        public bool HasBinocularEyes { get; set; } = true;
        public bool CanDetectInfrared { get; set; } = false;
        public bool CanSeeFar { get; set; } = true;
        public bool CanSeeInTheDark { get; set; } = true;

        public override string Sound()
        {
            return "hoot hoot";
        }
    }
}
