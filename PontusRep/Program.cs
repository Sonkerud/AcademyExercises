using System;

namespace PontusRep
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Ange antal sidor:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int pageCount))
            {
                pageCount = 10;
            }
            else
            {

            }
        

            Book bookOne = new Book(pageCount, "Lifaternerer");
            Book bookTwo = new Book(6000, "Allt om C#");

            Console.WriteLine(bookOne.Title);
           
        }

        private static void AddCalenderEvent(int day)
        {
            
        }
    }

    enum WeekDay
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday
    }
}
