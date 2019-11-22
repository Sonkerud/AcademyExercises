using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[1-9][0-9]+\s[1-9][0-9]$");
            Match match = regex.Match("134 45");

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
     
            //var match = Regex.Match(str, expr);
            //Console.WriteLine(match);
        }
    }
}
