using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleUtils
{
    public static class TextUtils
    {
        public static void AnimateText(string text, int delay)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}
