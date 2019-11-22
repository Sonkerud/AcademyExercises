using System;

namespace GenericDemo 
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfT<string> stringList = new ListOfT<string>();
            stringList.Add("hej");

            ListOfT<double> doubleList = new ListOfT<double>();
            doubleList.Add(1.2);
            doubleList.Add(21.2);
            doubleList.Add(3.2);
            doubleList.Add(4.2);
            doubleList[7] = 3;


            foreach (var item in doubleList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Console.WriteLine(doubleList[7]);
        }
    }
}
