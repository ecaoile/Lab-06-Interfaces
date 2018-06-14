using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    abstract class Canine : Mammal
    {
       public abstract bool MansBestFriend { get; set; }
       public override string Sound()
       {
            return "woof woof";
       }
    }
}
