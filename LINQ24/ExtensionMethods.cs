using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ24
{
    public static class ExtensionMethods
    {
        public static void CountOfPeopleForEachLetter(this List<Person> list)
            {
                string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ö", "ö", };

                for (int i = 0; i < alphabet.Length; i++)
                {
                Console.WriteLine($"Bokstav: {alphabet[i]} Antal: {list.Where(x => x.Name.ToLower().StartsWith(alphabet[i])).Count()}");
                }
                
            }

        public static List<Person> NamesThatStartsWith(this List<Person> list, string letters)
         => list.Where(x => x.Name.StartsWith(letters)).ToList();

        public static List<Person> NameThatStartsWithAndNameDayAtDay(this List<Person> list, string date, string letters)
        => list.Where(x => x.NameDay.ToString().StartsWith(date) && x.Name.StartsWith(letters)).ToList();

        public static List<Person> NameDayAtDay(this List<Person> list, string date)
        => list.Where(x => x.NameDay.ToString().StartsWith(date)).ToList();

        public static void NameDayEachMonth(this List<Person> list)
        {
            string[] months = new string[]
            {
                "01","02","03","04","05","06","07","08","09","10","11","12"
            };
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine($"Månad: {months[i]} Antal: {list.Where(x => x.NameDay.ToString().StartsWith($"2015-{months[i]}")).Count()}");
            }
        }

        public static void DateWithMostNameDays(this List<Person> list)
        {
            var newlist = list.GroupBy(x => x.NameDay).OrderByDescending(x => x.Count()).Take(5);
            Console.WriteLine("Topp fem dagar med flest namnsdagsbarn:");
            foreach (var item in newlist)
            {
                Console.WriteLine($"Datum: {item.Key.ToString().Replace("00:00:00", "")} Antal: {item.Count()}");
            }
        }

        public static void NameDayEachQuarter(this List<Person> list)
        {
           
            
            Console.WriteLine($"Kvartal 1: Antal: " +
            $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-01") || x.NameDay.ToString().StartsWith($"2015-02") || x.NameDay.ToString().StartsWith($"2015-03")).Count()}");

            Console.WriteLine($"Kvartal 2: Antal: " +
            $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-04") || x.NameDay.ToString().StartsWith($"2015-05") || x.NameDay.ToString().StartsWith($"2015-06")).Count()}");

            Console.WriteLine($"Kvartal 3: Antal: " +
            $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-07") || x.NameDay.ToString().StartsWith($"2015-08") || x.NameDay.ToString().StartsWith($"2015-09")).Count()}");

            Console.WriteLine($"Kvartal 4: Antal: " +
            $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-10") || x.NameDay.ToString().StartsWith($"2015-11") || x.NameDay.ToString().StartsWith($"2015-12")).Count()}");
        }

        public static void NameDayEachQuarter2(this List<Person> list)
        {
            int q = 1;
            string year = "2015";
            for (int i = 1; i <= 12; i+=3)
            {
                Console.WriteLine($"Kvartal {q}: Antal: " +
                $"{list.Where(x => x.NameDay.ToString().StartsWith(i < 10 ?$"{year}-0{i}" : $"{year}-{i}") || x.NameDay.ToString().StartsWith(i < 10 ? $"{year}-0{i+1}" : $"{year}-{i+1}") || x.NameDay.ToString().StartsWith(i < 10 ?$"{year}-0{i+2}" : $"{year}-{i+2}")).Count()}");
                q++; 
            }           
        }

        public static List<Months> GetMonths()
        {
             List<Months> months = new List<Months> { Months.January, Months.February, Months.Mars, Months.April, Months.May, Months.June, Months.July, Months.August, Months.September, Months.October, Months.November, Months.December };
             return months;
        }
    }
}
