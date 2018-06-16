using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_06_Interfaces.Classes
{
    public abstract class Animal
    {
        public string ZooName { get; set; } = "Code Fellows Zoo";
        public abstract bool IsWarmBlooded { get; set; }
        public abstract bool HasTeeth { get; set; }

        public virtual string Sleep()
        {
            return "ZzZzZz...";
        }

        public virtual string Sound()
        {
            return "...";
        }

        public virtual string Eat()
        {
            return "nom nom nom";
        }
    }
}
