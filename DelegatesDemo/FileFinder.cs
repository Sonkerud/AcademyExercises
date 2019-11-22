using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegatesDemo
{
   // public delegate bool Filter(string filePath);
    public static class FileFinder
    {

       public static void FindTextFiles(string dirPath,Func<string,bool> filter)
        {
            var filePaths = Directory.GetFiles(dirPath);
            foreach (var filepath in filePaths)
            {
                if (filter(filepath))
                {
                    Console.WriteLine(filepath);
                }
            }
        }

        public static bool Findstuff(string stuff)
        {
            return true;
        }
    }
}
