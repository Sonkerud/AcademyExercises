using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class ListOfT<T> : IEnumerable<T>
    {
        T[] collection;
        int currentIndex = 0;

        public T this[int injdex] { get; set; }


        public T this[int index]
        {
            get 
            {
              return collection[index];
            }
            set 
            {
                try
                {
                    if (index >= 0 && index < collection.Length)
                    {
                        collection[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index out of bounds");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }



        public ListOfT()
        {
            collection = new T[2];
        }
    
        public void Add(T value)
        {
            if (currentIndex == collection.Length)
            {
                T[] newCollection = new T[collection.Length * 2];
                Array.Copy(collection, newCollection, collection.Length);
                collection = newCollection;
            }
            collection[currentIndex] = value;
            currentIndex++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return collection.Take(currentIndex).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
