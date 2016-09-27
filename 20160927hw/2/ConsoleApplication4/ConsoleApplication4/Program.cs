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
            
            const double R = 2.0;
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            bool ret = true;
           
            ret = d <= R && x >= 0 && x >= y;
            Console.WriteLine(ret);
            Console.ReadKey(true);
        }
    }
}