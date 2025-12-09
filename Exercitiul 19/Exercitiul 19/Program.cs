using System;

class Program
{
    static void Main()
    {
        // Citim numarul
        Console.WriteLine("Introduceti un numar:");
        string numar = Console.ReadLine();

        // Set pentru a retine cifrele unice
        string cifreUnice = "";

        foreach (char c in numar)
        {
            if (!cifreUnice.Contains(c))
            {
                cifreUnice += c;
            }
        }

        // Verificam daca sunt exact 2 cifre unice
        if (cifreUnice.Length == 2)
        {
            Console.WriteLine("Numarul este format doar din doua cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine("Numarul NU este format doar din doua cifre.");
        }
    }
}
