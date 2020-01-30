using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        public Box(double length = 1.0, double width = 2, double height = 1.0)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Volume => Length * Height * Width;



        public static bool operator <(Box a, Box b)
        {
            return a.Volume < b.Volume;
        }


        public static bool operator >(Box a, Box b)
        {
            return a.Volume > b.Volume;
        }

        public static bool operator ==(Box a, Box b)
        {
            return a.Volume == b.Volume;
        }
        public static bool operator !=(Box a, Box b)
        {
            return a.Volume != b.Volume;
        }

        public override bool Equals(object obj)
        {
            if (obj is Box)
            {
                Box b = (obj as Box);
                return Length == b.Length && Width == b.Width && Height == b.Height;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode() + Width.GetHashCode() + Height.GetHashCode();
        }

        public static Box operator ++(Box a)
        {

            a.Length++;
            a.Width++;
            a.Height++;
            return a;
        }
    }
}
