using System;
using System.Collections.Generic;
using System.Text;

namespace PontusOODemo
{
    class Dog : Animal
    {
        public Dog() : base(4.5)
        {
            MakeSound();
        }
        public override void Eat(IEdible edible)
        {
            Weight += edible.Weight * 0.8;
            edible.Weight = 0;
        }

        public override void MakeSound()
        {
            Console.Beep(300,500);
        }
    }
}
