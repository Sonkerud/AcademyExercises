using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class Utils
    {
       public static bool IsOdd(this int i) => i % 2 != 0;

    }
}
