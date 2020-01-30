using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeDemo
{
    public class DisposeableClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Clean stuff");
        }
        public void DoStuff()
        {
            Console.WriteLine( "dsdf" );
        }

    }
}
