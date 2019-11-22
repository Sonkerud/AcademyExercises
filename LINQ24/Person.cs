using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ24
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public override string ToString()
        {
            return $"{Name} har namnsdag {NameDay}";
        }
    }
}
