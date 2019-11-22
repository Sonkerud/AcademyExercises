using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ24
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\TMP\names.csv";
            var listOfNames = ListCreator.CreateListFromFile(path);

       
            // List name that starts with
            var startWithAn = listOfNames.Where(x => x.Name.StartsWith("An"));
            //List Nameday at date
            var NameDayAtDate = listOfNames.Where(x => x.NameDay.ToString() == "2015-03-15 00:00:00");

            var namestart = NamesThatStartsWith(listOfNames,"Be");

            var nameAndDate = NameThatStartsWithAndNameDayAtDay(listOfNames, "2015-03-10", "Ad");

            //foreach (var item in namestart)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var person in nameAndDate)
            {
                Console.WriteLine(person);
            }

            //CountOfPeopleForEachLetter(listOfNames);
            //NameDayEachMonth(listOfNames);
            //NameDayEachQuarter(listOfNames);
            //DateWithMostNameDays(listOfNames);
        }

        static List<Person> NamesThatStartsWith(List<Person> list, string letters)
         => list.Where(x => x.Name.StartsWith(letters)).ToList();

        static List<Person> NameDayAtDay(List<Person> list, string date)
        => list.Where(x => x.NameDay.ToString().StartsWith(date)).ToList();

        static List<Person> NameThatStartsWithAndNameDayAtDay(List<Person> list, string date, string letters)
        => list.Where(x => x.NameDay.ToString().StartsWith(date)  && x.Name.StartsWith(letters)).ToList();

        static void CountOfPeopleForEachLetter(List<Person> list)
        {
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ö", "ö", };
            
            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine( $"Bokstav: {alphabet[i]} Antal: {list.Where(x => x.Name.ToLower().StartsWith(alphabet[i])).Count()}");
            }
        }

        static void NameDayEachMonth(List<Person> list)
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
        static void NameDayEachQuarter(List<Person> list)
        {
            string[] months = new string[]
            {
                "01","02","03","04","05","06","07","08","09","10","11","12"
            };
            
                    Console.WriteLine($"Kvartal 1: Antal: " +
                    $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-01") || x.NameDay.ToString().StartsWith($"2015-02") || x.NameDay.ToString().StartsWith($"2015-03")).Count()}");

                    Console.WriteLine($"Kvartal 2: Antal: " +
                    $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-04") || x.NameDay.ToString().StartsWith($"2015-05") || x.NameDay.ToString().StartsWith($"2015-06")).Count()}");

                    Console.WriteLine($"Kvartal 3: Antal: " +
                    $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-07") || x.NameDay.ToString().StartsWith($"2015-08") || x.NameDay.ToString().StartsWith($"2015-09")).Count()}");

                    Console.WriteLine($"Kvartal 4: Antal: " +
                     $"{list.Where(x => x.NameDay.ToString().StartsWith($"2015-10") || x.NameDay.ToString().StartsWith($"2015-11") || x.NameDay.ToString().StartsWith($"2015-12")).Count()}");
        }

        static void NameDayEachQuarter1(List<Person> list)
        {
            var newlist = list.GroupBy(x => x.NameDay.Month);
            Console.WriteLine(newlist.Where(x => x.));
        }

        static void DateWithMostNameDays(List<Person> list)
        {
            var newlist = list.GroupBy(x => x.NameDay);
            foreach (var item in newlist.OrderByDescending(x => x.Count()).Take(5))
            {
                Console.WriteLine($"Datum: {item.Key} Antal: {item.Count()}");
            }
        }
    }
}
