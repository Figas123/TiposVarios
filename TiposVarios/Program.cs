using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 1;
            int i = 2;
            char c1 = '\u003A';
            char c2 = '\u005E';
            char c3 = '\u0029';
            Console.WriteLine("short: " + s + "\nint: " + i + "\nchars: " + c1 + c2 + c3);
            Console.ReadKey();
        }
    }
}
