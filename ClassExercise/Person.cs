using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

         public Person(int id, string firstName, string lastName, string email, string phonenumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public Person()
        {

        }
        public void AddPersonToList(List<Person> list, string firstName, string lastName, string email, string phonenumber)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Email = email;
            person.PhoneNumber = phonenumber;
            list.Add(person);

        }

    }

    
}
