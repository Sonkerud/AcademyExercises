using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetDemo.Library.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string  FruitType { get; set; }
        public string FruitName { get; set; }
        public decimal PricePerKg { get; set; }


        public override string ToString()
        {
            return $"{FruitType} {FruitName} Price: {PricePerKg}";
        }
    }
}
