using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    public class Cat : Feline
    {
        public override bool AvoidHumans { get; set; } = false;
        public bool OwnsHumans { get; set; } = true;

        public override string Sound()
        {
            return "Meow!";
        }
        
        public virtual string KnockOverStuff(string objToKnockOver)
        {
            return $"broken {objToKnockOver}";
        }
    }
}
