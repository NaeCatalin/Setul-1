using System;

class Program
{
    static void Main()
    {
        // Citim numarul n de la tastatura
        Console.WriteLine("Introduceti un numar:");
        int n = int.Parse(Console.ReadLine());

        int numar = n;
        int factor = 2;

        Console.Write(n + " = ");

        bool primulFactor = true; // Pentru a nu pune 'x' in fata primului factor

        while (numar > 1)
        {
            int putere = 0;
            while (numar % factor == 0)
            {
                numar /= factor;
                putere++;
            }

            if (putere > 0)
            {
                if (!primulFactor)
                    Console.Write(" x ");
                Console.Write(factor + "^" + putere);
                primulFactor = false;
            }

            factor++;
        }

        Console.WriteLine();
    }
}
