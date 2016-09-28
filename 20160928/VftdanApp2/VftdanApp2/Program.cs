using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VftdanApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            char c;
            START:
            
            writeln("Введите число от 2 до 5");
            try
            {
                a = int.Parse(readln());
                switch (a)
                {
                    case 2: writeln("Двоечник"); break;
                    case 3: writeln("Троечник"); break;
                    case 4: writeln("Хорошист"); break;
                    case 5: writeln("Отличник"); break;
                    default: writeln("Введённое число не соответствует диапазону"); break;
                }
            }
            catch (SystemException) { writeln("Введённые данные не являются числом или не соответствуют диапазону");  }
            
        
                writeln("Ещё?(Y/N)");
            while (true)
            {
                c = Console.ReadKey().KeyChar;
                if (c == 'Y' || c == 'y') { writeln(); goto START; }
                if (c == 'N' || c == 'n') break;
            }
        }
        static void writeln(object s)
        {
            Console.WriteLine(s);
        }
        static void writeln()
        {
            writeln("");
        }
        static string readln()
        {
            return Console.ReadLine();
        }
    }
}
