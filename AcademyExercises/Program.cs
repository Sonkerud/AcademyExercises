using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyExercises
{
    class Program

    {
        static int i = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("hej....".Excite() ); 

            Console.ReadLine();

        }

        static int Addera(int ett, int två)
        {
            return ett + två;
        }

        static double Moms(double tal)
        {
            return tal * 1.25 - tal;
        }

        static double Moms(double tal, double moms)
            {
            
            return tal * (moms / 100 + 1);

        }

        static void BankSwitch()
        {
            List<string> saldo = new List<string>();
            List<double> summaSaldo = new List<double>();
            int account = 0;
            
            bool inmatning = true;
            while (inmatning)
            {
                Console.WriteLine("1. Insättning:");
                Console.WriteLine("2. Uttag:");
                Console.WriteLine("3. Saldo:");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Ange ditt val:");

                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Insättning:");
                        int deposit = int.Parse(Console.ReadLine());
                        account += deposit;
                        saldo.Add($"Insättning av {deposit} kronor");
                        summaSaldo.Add(deposit);
                        break;
                    case 2:
                        Console.WriteLine("Uttag:");
                        int withdrawel = int.Parse(Console.ReadLine());
                        account -= withdrawel;
                        saldo.Add($"Uttag av {withdrawel} kronor");
                        summaSaldo.Add(withdrawel);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"\nSaldo:{account}");
                        Console.WriteLine("Historik");
                        var onlyTen = saldo.TakeLast(10);
                        foreach (var item in onlyTen)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        inmatning = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void whileLoop()
        {
            bool inmatning = false;
            while (!inmatning)
            {
                try
                {
                    i = int.Parse(Console.ReadLine());

                    if (i < 0 || i > 100)
                    {
                        Console.WriteLine("Fel nr");
                    }
                    else
                    {
                        inmatning = true;
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Ange ett tal mellan 0-100");
                }
            }

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 101);
        }
    }
}
