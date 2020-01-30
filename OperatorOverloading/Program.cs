using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box boxA = new Box(0.5,2,1);
            Box boxB = new Box(0.5,2,1);

            if (boxA == boxB)
            {
                Console.WriteLine("Samma");
            }


            var nyBox = boxA++;

            Console.WriteLine(nyBox.Height);
            Console.WriteLine(nyBox.Width);
            Console.WriteLine(nyBox.Length);
        }
    }
}
