using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Adam", "Eva","Benny","John","Adrian" };
            AddName(names, "Henry");
            RemoveName(names,"Eva");
            

            var sorted = SortNames(names,x => x.OrderBy(x => x).ToList());

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }

        static void AddName(List<string> list, string str)
        {
            list.Add(str);
        }

        static void RemoveName(List<string> list, string str)
        {
            list.Remove(str);
        }

        static List<string> SortNames(List<string> list, Func<List<string>,List<string>> func)
        {
            return func(list);
        }

        static IEnumerable<string> SortByName(List<string> list)
        {
            return list;
        }

    }
}
