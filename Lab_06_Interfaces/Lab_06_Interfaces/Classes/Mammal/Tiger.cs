﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    public class Tiger : Feline
    {
        public override bool AvoidHumans { get; set; } = true;
        public bool IsStriped {get; set;} = true;

        public string FrostedFlakes()
        {
            return "They're grrrrrreat!";
        }
    }
}
