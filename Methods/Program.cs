using AcademyExercises;
using System;

namespace Methods
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Person aPerson = new Person();
            aPerson.FirstName = "Anna";
            aPerson.LastName = "Anka";
            aPerson.Age = 30;

            Person anotherPerson = aPerson.Clone();
            anotherPerson.FirstName = "Malin";
            aPerson.PrintPropertyValuesToConsole();
            anotherPerson.PrintPropertyValuesToConsole();


            //PersonStruct personStruct = new PersonStruct();
            //personStruct.Age = 30;
            //personStruct.FirstName = "haall";
            //personStruct.LastName = "Hilsseon";
            //Console.WriteLine($"{personStruct.FirstName} {personStruct.LastName} {personStruct.Age}");
            //PersonStructMethod(personStruct);
            //Console.WriteLine($"{personStruct.FirstName} {personStruct.LastName} {personStruct.Age}");

            //Console.ReadLine();
            //Person person = new Person { FirstName = "Adrian", LastName = "Aronsson", Agwe = 32 };
            //Console.WriteLine($"{person.FirstName} {person.LastName} {person.Agwe}");
            //persondd(person);
            //Console.WriteLine($"{person.FirstName} {person.LastName} {person.Agwe}");

        }

        static void persondd(Person person)
        {
            person.Age = 33;
            person.FirstName = "Bulle";
            person.LastName = "Eriksson";
         

        }

      
        static void PersonStructMethod(PersonStruct personStruct)
        {
            personStruct.FirstName = "Hans";
            personStruct.LastName = "Hansson";
            personStruct.Age = 30;
            
        }
    }

    struct PersonStruct
    {
        public string FirstName;
        public string LastName;
        public int Age;

    }

    
}
