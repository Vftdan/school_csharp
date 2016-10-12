using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Сделал Закируллин 10МИ3
namespace luckynum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i,s1,s2,semi,l;
            var dig = new int[10];

            char exit_key;
            while (true)
            {
                num = promptInt("целое число от нуля до 2147483648 с чётным количеством цифр");
                for (i = 0; true; i++)
                {
                    dig[i] = num % 10;
                    if (num < 10) break;
                    num = num / 10;
                }
                if (i % 2 == 0) { writeln("Число имеет нечётное количество цифр"); continue; };
                l = i+1;
                semi = l / 2;
                s1 = s2 = 0;
                for (i = 0; i < semi;i++ )
                {
                    s2 += dig[i];
                }
                for (i = 0; i < semi;i++ )
                {
                    s1 += dig[semi+i];
                }
                if (s1 == s2) writeln(String.Format("Счастливое ({0}=={1})", s1, s2)); else writeln(String.Format("Несчастливое ({0}!={1})", s1, s2));
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
