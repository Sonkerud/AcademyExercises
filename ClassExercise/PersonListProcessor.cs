using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExercise
{
    class PersonListProcessor
    {
        public List<Person> CreateList() 
        {
            return new List<Person>();
        }

        void AddPersonToList(List<Person> personList)
        {
            Person person = new Person();
            if (personList.Count != 0)
            {
                person.Id = personList.Max(x => x.Id) + 1;
            }
            else
            {
                person.Id = 0;
            }
            
            Console.WriteLine("Firstname:");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Lastname:");
            person.LastName = Console.ReadLine();
            person.Email = $"{person.FirstName}.{person.LastName}@academy.se";
            Console.WriteLine("Phonenumber:");
            person.PhoneNumber = Console.ReadLine();
            personList.Add(person);
        }
        
        void RemovePersonFromList(List<Person> personList)
        {
            Console.WriteLine("Firstname of person you want to remove:");
            string firstName = Console.ReadLine();
            foreach (var item in personList)
            {
                if (item.FirstName.Contains(firstName))
                {
                    personList.Remove(item);
                }
                else
                {
                    Console.WriteLine($"{firstName} doesn't exist in list");
                }
            }
        }

        List<Person> SortByFirstName(List<Person> personList)
        {
            return personList.OrderBy(x => x.FirstName).ToList();
        }

        List<Person> SortByLastName(List<Person> personList)
        {
            return personList.OrderBy(x => x.LastName).ToList();
        }

        public bool MenuSwitch(List<Person> inputList)
        {
            Console.Clear();
            Console.WriteLine("1. Add person");
            Console.WriteLine("2. Remove person");
            Console.WriteLine("3. Sort list");
            Console.WriteLine("4. Show me the list");
            Console.WriteLine("5. Edit list");
            Console.WriteLine("6. Exit program");

            var personList = inputList;

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AddPersonToList(personList);
                    return true;
                case 2:
                    RemovePersonFromList(personList);
                    return true;
                case 3:
                    inputList = SortOptionsSwitch(personList);
                    MenuSwitch(inputList);
                    return true;
                case 4:
                    WriteList(personList);
                    return true;
                case 5:
                    EditList(personList);
                    return true;
                case 6:
                    return false;
                default:
                    MenuSwitch(personList);
                    return true;
            }
        }

        void EditList(List<Person> personList)
        {
            Console.Clear();
            WriteList(personList);

            Console.WriteLine("Id for person you want to edit:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Edit first name");
            Console.WriteLine("2. Edit last name");
            Console.WriteLine("3. Edit e-mail");
            Console.WriteLine("4. Edit phone number");
            

            int input = int.Parse(Console.ReadLine());
            var personToEdit = personList.First(x => x.Id == id);
            switch (input)
            {
                
                case 1:
                    Console.WriteLine("\n Input new first name:");
                    personToEdit.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n Input new last name:");
                    personToEdit.LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("\n Input new e-mail:");
                    personToEdit.Email = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n Input new phone number:");
                    personToEdit.PhoneNumber = Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

        List<Person> SortOptionsSwitch(List<Person> personList)
        {
            Console.WriteLine("1. Sort by firstname");
            Console.WriteLine("2. Sort by lastname");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    return SortByFirstName(personList);
                    
                case 2:
                    return SortByLastName(personList);
                    
                default: 
                    return personList;
                    
            }
        }

        void WriteList(List<Person> personList)
        {
            foreach (var item in personList)
            {
                Console.WriteLine($"Id: {item.Id} First name: {item.FirstName} Last name: {item.LastName} E-mail: {item.Email} Phone number: {item.PhoneNumber}");
            }
            
            Console.ReadLine();
        }
    }
}
