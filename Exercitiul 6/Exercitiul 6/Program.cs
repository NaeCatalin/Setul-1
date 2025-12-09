//Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

using System;
using System.ComponentModel.Design;

class Program

{
    static void Main()
    {
        Console.Write("Introduceti valoarea lui a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceti caloarea lui b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Introduceti valoarea lui c");
        double c = double.Parse(Console.ReadLine());

        // verificam daca sunt pozitive
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Toate valorile trebuie sa fie pozitive");
        }

        else
        {
            if (a + b > c && b + c > a && c + a > b) 
            {
                Console.Write("Numerele pot forma un tringhi");
            }
            else
            {
                Console.Write("Numerele nu pot forma un triunghi");
            }
        }
    }
}

