
using System;
class class1
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y;
        if (x <= -0.5)  y = 0.5;  else
            if (x <= 0)  y = x+1;  else
                if (x <= 1)  y = x * x - 1; 
                else
                 y = x - 1; 
        
        Console.WriteLine(y);           
        Console.ReadKey(true);               
    }
}

