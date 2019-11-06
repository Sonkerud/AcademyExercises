using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyExercises
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person Clone()
        {
            Person newPerson = new Person();
            newPerson.FirstName = FirstName;
            newPerson.LastName = LastName;
            newPerson.Age = Age;
            return newPerson;
            
        }

        public void PrintPropertyValuesToConsole()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} Ålder: {this.Age}");
        }
    }
}
