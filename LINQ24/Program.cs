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
            string path = @"C:\projects\names.csv";
            FileProcessor fileProcessor = new FileProcessor(path);
            var listOfNames = fileProcessor.PersonListCreator();

            var filteredOnStartOfName = listOfNames.NamesThatStartsWith("Be");
            var filteredOnNameDay = listOfNames.NameDayAtDay("2015-05-08");
            var filteredOnBoth = listOfNames.NameThatStartsWithAndNameDayAtDay("2015-03-10", "Ad");

            foreach (var person in filteredOnBoth)
            {
                Console.WriteLine($"{ person.Name} {person.NameDay.ToString().Replace("00:00:00","")}");
            }


            listOfNames.CountOfPeopleForEachLetter();
            listOfNames.NameDayEachMonth();
            listOfNames.NameDayEachQuarter();
            listOfNames.DateWithMostNameDays();
        }
    }
}
