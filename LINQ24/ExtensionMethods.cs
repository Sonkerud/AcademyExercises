using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ24
{
    static class ExtensionMethods
    {

        static void CountOfPeopleForEachLetter(this List<Person> list)
        {
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ö", "ö", };

            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine($"Bokstav: {alphabet[i]} Antal: {list.Where(x => x.Name.ToLower().StartsWith(alphabet[i])).Count()}");
            }
        }
    }
}
