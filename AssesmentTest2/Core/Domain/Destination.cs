using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Destination
    {
        public string Name { get; set; }
        public List<Hotel> HotelList { get; set; } = new List<Hotel>();
        public List<string> HotelNames { get 
            {
                return HotelList.Select(x => x.Name).ToList();
            }  }

        public int TotalNumberOfPools {
            get { return HotelList.Select(x => x.NumberOfPools).Sum(); }
             }
        public int MaxPools { get {
                return HotelList.Select(x => x.NumberOfPools).Max();
            }  }

        public Destination(string name)
        {
            Name = name;
        }
        public void AddHotel(string name, int nr)
        {
            HotelList.Add(new Hotel (name, nr));
        }

        public string GetName()
        {
            return $"DESTINATION {Name.ToUpper()}";
        }

    }
}
