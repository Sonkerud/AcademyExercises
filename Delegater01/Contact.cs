using System;
using System.Collections.Generic;
using System.Text;

namespace Delegater01
{
    public class Contact
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Contact(string first, string last, int age)
        {
            Age = age;
            FirstName = first;
            LastName = last;
        }
        public override string ToString()
        {
            return $"{LastName}{FirstName},{Age}";
        }
    }
}
