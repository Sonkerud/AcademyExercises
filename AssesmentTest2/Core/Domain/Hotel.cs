using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Hotel
    {
        public string Name { get; set; }
        public int NumberOfPools { get; set; }
        public List<Suits> SuitList { get; set; } = new List<Suits>();
        public string Description { get {
                return $"{Name} has {NumberOfPools} pools";
            }}

        public Hotel(string name, int nr)
        {
            Name = name;
            NumberOfPools = nr;
        }
        public void SuitsGroup(string suit)
        {
          
            if (Enum.TryParse(suit, out Suits myStatus))
            {
                if (Suits(myStatus))
                {
                    throw new ArgumentException();
                }
                else
                {
                    SuitList.Add(myStatus);
                }
            } else
            {
                throw new ArgumentException();
            }
        }


        public bool Suits(Suits suit) => SuitList.Any(x => x == suit);
       
    }
}
