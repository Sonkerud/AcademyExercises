using System;

namespace DisposeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //DisposeableClass disposeableClass = new DisposeableClass();

            //disposeableClass.Dispose();

            using (DisposeableClass dc = new DisposeableClass())
            {
                dc.DoStuff();

            }

        }
    }
}
