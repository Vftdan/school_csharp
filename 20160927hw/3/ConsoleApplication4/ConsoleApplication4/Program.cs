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
            
            
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            
            double ret=0;
            if (x < y && x > 0) ret = x+Math.Sin(y);
            else
            if (x > y && x < 0) ret = y-Math.Cos(x); else ret=0.5*x*y;
           
            
            Console.WriteLine(ret);
            Console.ReadKey(true);
        }
    }
}