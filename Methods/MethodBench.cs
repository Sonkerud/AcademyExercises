using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class MethodBench
    {

        public delegate bool Del();
        

        public void FirstMethod()
        {
            
            Console.WriteLine("Merry Methods");
        }

        public void SecondMethod(string str)
        {
            Console.WriteLine(str);
        }


        public void ThirdMethod(string str, Del del)
        {
            str = (del()) ? str.ToUpper() : str.ToLower();
            SecondMethod(str.ToUpper());
        }


        public void ThirdMethodFunc(string str, Func<bool> del)
        {
            str = (del()) ? str.ToUpper() : str.ToLower();
            SecondMethod(str.ToUpper());
        }


        public bool FourthMethod()
        {
            Console.WriteLine("Vill du skrika(s) eller viska(v)?");
           
            string voice = "";  

            while (voice != "v" && voice != "s")
            {
                voice = Console.ReadLine();
            }
            return (voice == "s") ? true : false;          
        }

        public bool FifthMethod()
        {
            Console.WriteLine("Små eller stora bokstäver? 1: För stora 2: För små.");
            var c = Console.ReadLine();
            return (c == "1") ? true : false;
        }
    }
}
