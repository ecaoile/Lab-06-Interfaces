using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes.Mammal
{
    class Wolf : Canine
    {
        public override bool MansBestFriend { get; set; } = false;
        public override bool CanPet { get; set; } = true;
    }
}
