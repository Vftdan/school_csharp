using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            byte dig = Byte.Parse(Console.ReadLine());
            byte ch = Byte.Parse(Console.ReadLine());
            if (dig < '0' || dig > '9' || ch < 'A' || ch + dig - '0' > 'Z') { Console.WriteLine(fromCharCode(ch)); goto END; };
            Console.WriteLine( fromCharCode(ch+dig-'0') );
            END:
            Console.ReadKey(true);
        }
        static string fromCharCode(byte c)
        {
            return fromCharCode((int)c);
        }
        static string fromCharCode(int c)
        {
            return Char.ConvertFromUtf32(c);
        }
    }
}