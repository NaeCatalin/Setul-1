using System;

class Program
{
    static void Main()
    {
        // Citim cele 5 numere de la tastatura
        Console.WriteLine("Introduceti primul numar:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al treilea numar:");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al patrulea numar:");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al cincilea numar:");
        int e = int.Parse(Console.ReadLine());

        int temp;

        // Sortare prin metoda schimbarii valorilor (bubble sort simplificat)
        if (a > b) { temp = a; a = b; b = temp; }
        if (a > c) { temp = a; a = c; c = temp; }
        if (a > d) { temp = a; a = d; d = temp; }
        if (a > e) { temp = a; a = e; e = temp; }

        if (b > c) { temp = b; b = c; c = temp; }
        if (b > d) { temp = b; b = d; d = temp; }
        if (b > e) { temp = b; b = e; e = temp; }

        if (c > d) { temp = c; c = d; d = temp; }
        if (c > e) { temp = c; c = e; e = temp; }

        if (d > e) { temp = d; d = e; e = temp; }

        // Afisam numerele in ordine crescatoare
        Console.WriteLine("Numerele in ordine crescatoare sunt:");
        Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
    }
}
