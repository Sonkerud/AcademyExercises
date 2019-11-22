using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class ListOfInt
    {
        int[] collection;
        int currentIndex = 0;

        public int this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }

        public ListOfInt()
        {
            collection = new int[2];
        }

        public void Add(int value)
        {
            if (currentIndex == collection.Length)
            {
                int[] newCollection = new int[collection.Length * 2];
                Array.Copy(collection, newCollection, collection.Length);
                collection = newCollection;
            }
            collection[currentIndex] = value;
            currentIndex++;
        }
    }
}
