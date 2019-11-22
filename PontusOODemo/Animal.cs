using System;
using System.Collections.Generic;
using System.Text;

namespace PontusOODemo
{
    class Animal: IEdible
    {
        public double Weight { get; set; }

        public Animal(double weight)
        {
            Weight = weight;
        }

        public virtual void Eat(IEdible edible)
        {
            Weight += edible.Weight;
            edible.Weight = 0;
        }

        public override string ToString()
        {
            return $"{Weight}";
        }

        public virtual void MakeSound()
        {
            Console.Beep(800,500);
        }
    }
}
