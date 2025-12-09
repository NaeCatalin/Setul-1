using System;

class Program
{
    static void Main ()
            {
        Console.WriteLine("Introduceti valoarea lui a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti valoarea lui b:");
        int b = int.Parse(Console.ReadLine());
        // Scimbarea valorilor 
        int temp = a;
        a= b;
        b= temp;
        Console.WriteLine("Dupa schimbare, valoarea lui a este: " + a);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}