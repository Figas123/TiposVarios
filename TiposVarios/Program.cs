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
            float f = 1f;
            double d = 2;
            bool b1 = false;
            bool b2 = true;
            Console.WriteLine("short: " + s + "\nint: " + i + "\nchars: " + c1 + c2 + c3 + "\nfloat: " + f + "\ndouble: " + d + "\nsmart= " + b1 + "\ndumb= " + b2);
            Console.WriteLine("\nstring\\\t\\normal\n" + @"string\\\t\\verbatim\n" + "\n" + "normal:\u003A\u005E\u0029\n" + @"verbatim:\u003A\u005E\u0029");
            Console.WriteLine($"\nnormal\nshort: {s}\nint: {i}\nchars: {c1}{c2}{c3}" + "\n\n" + $@"\nverbatim\nshort: {s}\nint: {i}\nchars: {c1}{c2}{c3}");
            Console.ReadKey();
        }
    }
}