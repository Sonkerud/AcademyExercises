using System;
using System.Collections.Generic;
using System.Text;

namespace PontusOODemo
{
    class Grass : IEdible
    {
        public double Weight { get; set; }

        public Grass(double weight)
        {
            Weight = weight;
        }

        
    }
}
