using System;
using System.Collections.Generic;
using System.Text;

namespace PontusOODemo
{
    class Cat : Animal
        
    {
        public Cat(double weight) : base(weight)
        {

        }

        public override string ToString()
        {
            return $"Katt - {base.ToString()}";
        }
    }
}
