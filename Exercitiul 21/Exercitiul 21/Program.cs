using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gandeste-te la un numar intre 1 si 1024.");
        Console.WriteLine("Raspunde la intrebari cu 'da' sau 'nu'.\n");

        int stanga = 1;
        int dreapta = 1024;

        while (stanga < dreapta)
        {
            int mijloc = (stanga + dreapta) / 2;
            Console.Write($"Numarul este mai mare sau egal decat {mijloc}? (da/nu): ");
            string raspuns = Console.ReadLine().ToLower();

            if (raspuns == "da")
            {
                stanga = mijloc;
            }
            else if (raspuns == "nu")
            {
                dreapta = mijloc - 1;
            }
            else
            {
                Console.WriteLine("Raspunde cu 'da' sau 'nu'.");
            }
        }

        Console.WriteLine($"\nNumarul tau este {stanga}!");
    }
}

