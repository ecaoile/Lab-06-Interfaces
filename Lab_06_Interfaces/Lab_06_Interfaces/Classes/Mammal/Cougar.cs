using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    public class Cougar : Feline
    {
        public override bool CanPet { get; set; } = false;
        public override bool AvoidHumans { get; set; } = true;
        public override string Sound()
        {
            return "Growl, hiss, purr!";
        }
    }
}
