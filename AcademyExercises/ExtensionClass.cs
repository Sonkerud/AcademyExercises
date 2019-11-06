using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyExercises
{
    public static class ExtensionClass
    {
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }

        public static string Excite(this string str)
        {
            return str.Replace(".", "!");
        }
    }
}
