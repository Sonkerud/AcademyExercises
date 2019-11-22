using ConsoleUtils;
using System;
using System.Collections.Generic;

namespace PontusOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(3);
            Dog dog = new Dog();
            dog.Weight = 18;
            
            TextUtils.AnimateText("Welcome", 200);

            var animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                animal.Eat(new Cat(1));

                Console.WriteLine(animal);
            }

            Console.WriteLine(cat.Weight);
            Console.WriteLine(dog.Weight);

        }
    }
}
