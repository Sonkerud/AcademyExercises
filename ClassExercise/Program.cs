using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassExercise
{
    class Program
    {
        //static public List<Person> personList = new List<Person>();
        static PersonListProcessor listProcessor = new PersonListProcessor();

        static void Main(string[] args)
        {
            var personList = listProcessor.CreateList();
            RunProgram(personList);
        }
        public static void RunProgram(List<Person> personList)
        {
            personList.Add(new Person { Id = 0, FirstName = "Agneta", LastName = "Bennysson", Email = "arne@gmail.com", PhoneNumber = "0702345667" });
            personList.Add(new Person { Id = 1, FirstName = "Bengt", LastName = "Andersson", Email = "arne@gmail.com", PhoneNumber = "0702345667" });
            personList.Add(new Person { Id = 2, FirstName = "Lennart", LastName = "Svensson", Email = "kose@gmail.com", PhoneNumber = "0702345457" });
            personList.Add(new Person { Id = 3, FirstName = "Östen", LastName = "Persson", Email = "kose@gmail.com", PhoneNumber = "0702345457" });
            personList.Add(new Person { Id = 4, FirstName = "Lisa", LastName = "Sundström", Email = "kose@gmail.com", PhoneNumber = "0702345457" });

            while (true)
            {
                listProcessor.MenuSwitch(personList);
            }
        }
    }
}
