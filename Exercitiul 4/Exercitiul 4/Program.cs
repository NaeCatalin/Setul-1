using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti anul y:");
        int y = int.Parse(Console.ReadLine());
        
        if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
        {
            Console.WriteLine("Anul {0} este an bisect.", y);
        }
        else
        {
            Console.WriteLine("Anul {0} nu este an bisect.", y);
        }
    }
}