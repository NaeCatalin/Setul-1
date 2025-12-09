using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti primul numar: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int c = int.Parse(Console.ReadLine());

        int primul, alDoilea, alTreilea;

        // Determinam primul
        if (a <= b && a <= c)
            primul = a;
        else if (b <= a && b <= c)
            primul = b;
        else
            primul = c;

        // Determinam al treilea
        if (a >= b && a >= c)
            alTreilea = a;
        else if (b >= a && b >= c)
            alTreilea = b;
        else
            alTreilea = c;

        // Determinam al doilea
        alDoilea = a + b + c - primul - alTreilea;

        Console.WriteLine("Numerele in ordine crescatoare: " + primul + " " + alDoilea + " " + alTreilea);
    }
}
