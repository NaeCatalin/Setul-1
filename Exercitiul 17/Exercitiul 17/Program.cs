using System;

class Program
{
    static void Main()
    {
        // Citim cele doua numere de la tastatura
        Console.WriteLine("Introduceti primul numar:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar:");
        int b = int.Parse(Console.ReadLine());

        int x = a;
        int y = b;

        // Algoritmul lui Euclid pentru CMMD
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        int cmmdc = x;

        // CMMMC se calculeaza astfel: a * b / cmmdc
        int cmmmc = (a * b) / cmmdc;

        Console.WriteLine("Cel mai mare divizor comun (CMMD) este: " + cmmdc);
        Console.WriteLine("Cel mai mic multiplu comun (CMMMC) este: " + cmmmc);
    }
}
