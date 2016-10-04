using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons161004
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = args.Length>0 ? int.Parse(args[0]) : 1;
            var x = double.Parse(prompt("x"));
            switch (v)
            {
                case 1: v1(x); break;
                case 2: v2(x); break;
                case 3: v3(x); break;

            }
            Console.ReadKey(true);
        }
        static void v1(double x)
        {
            double y;
            if (x < -1) { y=(1.0); }
            else
            if (x < 0) { y=(0.3); }
            else
            if (x < 1) { y=(x*x); }
            else { y=(1.0); }
            writeln("y="+y);

        }
        static void v2(double x)
        {
            double y;
            if (x < -1) { y = (0.0); }
            else
            if (x < 0) { y = (x+1.0); }
            else
            if (x < 1) { y = (x-1.0); }
            else { y = (0.0); }
            writeln("y=" + y);

        }
        static void v3(double x)
        {
            var y = double.Parse(prompt("y"));
            var r = Math.Sqrt(x * x + y * y);
            writeln("flag="+((r<=2&&r>=1&&x>=0)?1:0));
        }
        static string prompt(string s)
        {
            writeln("Введите "+s);
            return Console.ReadLine();

        }
        static void writeln(string s)
        {
            Console.WriteLine(s);

        }
        static void writeln(object s)
        {
            
            writeln(s.ToString());

        }
    }
}
