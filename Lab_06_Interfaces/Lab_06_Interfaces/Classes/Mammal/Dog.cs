using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    class Dog : Canine
    {
        public override bool CanPet { get; set; } = true;
        public override bool MansBestFriend { get; set; } = true;
        public virtual bool IsAGoodBoyOrGirl { get; set; } = true;
        public virtual bool CanHaveMaster { get; set; } = true;
    }
}
