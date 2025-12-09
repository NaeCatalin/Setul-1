using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul n: ");
        int n = int.Parse(Console.ReadLine());

        int original = n;
        int invers = 0;

        // Tratam numere negative
        if (n < 0)
        {
            Console.WriteLine("Numerele negative NU sunt palindrom.");
            return;
        }

        while (n > 0)
        {
            int cifra = n % 10;
            invers = invers * 10 + cifra;
            n /= 10;
        }

        if (original == invers)
            Console.WriteLine("Numarul este palindrom.");
        else
            Console.WriteLine("Numarul NU este palindrom.");
    }
}
