using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    class Tiger : Feline
    {
        public override bool AvoidHumans { get; set; } = true;
        public virtual bool IsStriped {get; set;} = true;

        public string FrostedFlakes()
        {
            return "They're grrrrrreat!";
        }
    }
}
