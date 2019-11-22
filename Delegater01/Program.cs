using System;
using System.Diagnostics;
using System.Linq;

namespace Delegater01
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stop = new Stopwatch();

            //Cigarr("hejehHH", x => Console.WriteLine(x.ToLower()));
            // Cigarr("humor",Scream);
            //PrintIt2("hejDSJHDF", x => x.ToLower());
            //PrintIt2("hejDSJHDF", Whisper);
 
          //  int[] intArr = { 77, 2, 4, 11, 50, 21, 1 };
            //string[] strArr = {"laban","kurre","banan", "uiu"};

                     

            Contact[] contactArr = new Contact[]
            {
                new Contact("Adrian", "Hansson", 3),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 3),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36),
                 new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 2),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 4),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36), new Contact("Adrian", "Hansson", 31),
                new Contact("Joel", "Pansson", 32),
                new Contact("Ana", "Olsson", 33),
                new Contact("Peo", "Ison", 27),
                new Contact("Peo", "Ison", 29),
                new Contact("Peo", "Ison", 28),
                new Contact("Teo", "Ison", 99),
                new Contact("Peo", "Ison", 1),
                new Contact("Peo", "Ison", 123),
                new Contact("Aeo", "Ison", 35),
                new Contact("Beo", "Ison", 36),
            };

            stop.Start();
            Console.WriteLine("using first");
            var firstPerson = contactArr.First(x => x.Age == 3 && x.FirstName == "Peo" && x.LastName == "Ison");
            Console.WriteLine(firstPerson);
            stop.Stop();

            Console.WriteLine(stop.Elapsed);


            stop.Reset();
            stop.Start();
            Console.WriteLine("using where");

            var secondPerson = contactArr.Where(x => x.Age == 28 && x.FirstName == "Peo" && x.LastName == "Ison");

            foreach (var item in secondPerson)
            {
                Console.WriteLine(item.FirstName);

            }

            stop.Stop();
            Console.WriteLine(stop.Elapsed);


            //Namngiven metod - övning 10
            //foreach (var item in contactArr.SortGenArray(Sorter3))
            //{
            //    Console.WriteLine(item);
            //}

            //lambda uttryck - övning 10
            //foreach (var item in contactArr.SortGenArray((first,last) =>

            //string.Compare(first.LastName, last.LastName, true) < 0
            //? true
            //: string.Compare(first.LastName, last.LastName, true) == 0 && string.Compare(first.FirstName, last.FirstName, true) < 0
            //? true
            //: string.Compare(first.FirstName, last.FirstName, true) == 0 && first.Age < last.Age
            //? true
            //: false

            //))
            //{
            //    Console.WriteLine(item);
            //}

        }

        static bool Sorter3(Contact first, Contact last) =>
            string.Compare(first.LastName, last.LastName, true) < 0
            ? true
            : string.Compare(first.LastName, last.LastName, true) == 0 && string.Compare(first.FirstName, last.FirstName, true) < 0
            ? true
            : string.Compare(first.FirstName, last.FirstName, true) == 0 && first.Age < last.Age
            ? true
            : false;

        //true = går in i if-sats
        static bool Sorter1(Contact c1, Contact c2)
        =>
        string.Compare(c1.LastName, c2.LastName, true) < 0
        ?
        true
        //: string.Compare(c1.LastName, c2.LastName, true) > 0
        //? false
        : string.Compare(c1.LastName, c2.LastName, true) == 0 ?
         //?

         // string.Compare(c1.FirstName, c2.FirstName, true) < 0
         //:
         //true
         //? string.Compare(c1.FirstName, c2.FirstName, true) > 0
         //: false
         //? string.Compare(c1.FirstName, c2.FirstName, true) == 0

         c1.Age < c2.Age : false;

        static bool Sorter2(Contact c1, Contact c2 )
        {
            if (string.Compare(c1.LastName, c2.LastName, true) < 0)
            {
                return true;
            }
            else if (string.Compare(c1.LastName, c2.LastName, true) > 0)
            {
                return false;
            }
            else if (string.Compare(c1.LastName, c2.LastName, true) == 0)
            {
                if (string.Compare(c1.FirstName, c2.FirstName, true) > 0)
                {
                    return true;
                }
                else if (string.Compare(c1.FirstName, c2.FirstName, true) < 0)
                {
                    return false;
                }
                else if (string.Compare(c1.FirstName, c2.FirstName, true) == 0)
                {
                    if (c1.Age > c2.Age)
                    {
                        return true;
                    }
                }
            }
           
                return false;
           

        }

        //static bool CompareString(string str, string str1)
        //{
        //    return string.Compare(str, str1, true) < 0;
        //}

        //static string AddThree(Func<string,bool> b, Func<Func<string,bool>,string,string> sb, string str)
        //{
        //    return sb(b,str);
        //}

        //static void SomeMethod(string str, Func<string,bool> b)
        //=> Console.WriteLine(b(str) ? str.ToUpper() : str.ToLower());

        //static void SomeMethod(string str, Func<bool> b)
        //=> Console.WriteLine(b() ? str.ToUpper() : str.ToLower());


        static void PrintIt2(string str, Func<string,string> action)
        {
            Console.WriteLine(action(str)); 
        }

        static void PrintIt(string str, bool b)
       
        {
            if (b)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());
            }
        }

        static void Cigarr(string str, Action<string> action)
        {
            action(str); 
        }

        static string Scream(string str)
        {
            return str.ToUpper();
        }

        static string Whisper(string str)
        {
            return str.ToLower();
        }

        static bool IsLessThan(int i, int y)
        => i < y;

        static bool IsMoreThan(int i, int y)
        => i > y;

    }
}
