using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace splitint
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            var dig=new int[10];

            char exit_key;
            while (true)
            {
                num = promptInt("целое число от нуля до 2147483648");
                for (i = 0; true;i++ )
                {
                    dig[i] = num % 10;
                    if(num<10)break;
                    num = num / 10;
                }
                for (; i > -1; i--)
                {
                    writeln(dig[i]);
                }

                writeln("Начать заново? (Y/N Default:Y)");
                exit_key = (char)pause().Key;
                if (exit_key == 'N') { break; }
            }
        }
        static void writeln(object o)
        {
            Console.WriteLine(o);
        }
        static string readln()
        {
            return Console.ReadLine();
        }
        static string prompt(string s)
        {
            writeln("Введите " + s);
            return readln();
        }
        static int promptInt(string s)
        {
            int r;
            do
            {
                try
                {
                    r = int.Parse(prompt(s));
                    break; 
                }
                catch (Exception e) { }

            } while (true);
            return r;
        }
        static ConsoleKeyInfo pause()
        {
            return Console.ReadKey(true);
        }
    }
}
