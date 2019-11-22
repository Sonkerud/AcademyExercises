using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
   
        public class ListOfPerson
        {
            Person[] collection;
            int currentIndex = 0;

            public ListOfPerson()
            {
                collection = new Person[2];
            }

            public void Add(Person value)
            {
                if (currentIndex == collection.Length)
                {
                    Person[] newCollection = new Person[collection.Length * 2];
                    Array.Copy(collection, newCollection, collection.Length);
                    collection = newCollection;
                }
                collection[currentIndex] = value;
                currentIndex++;
            }
        }
    
}
