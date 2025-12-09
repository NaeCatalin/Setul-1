using System;

class Program

{
    static void Main(string[] args)
    {
        Console.Write("Introduceti un numar n: ");
        string? nInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nInput))
        {
            Console.WriteLine("Valoare introdusa pentru n nu este valida.");
            return;
        }
        long n = long.Parse(nInput);

        Console.Write("Introduceti pozitia k:");
        string? kInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(kInput))
        {
            Console.WriteLine("Valoare introdusa pentru k nu este valida.");
            return;
        }
        int k = int.Parse(kInput);
        //Lucram cu valoarea absoluta pt a evita probleme nu numerele negative
        long absN = Math.Abs(n);
        //Verificam daca nr are cel putin k cifre
        if (absN < (long)Math.Pow(10, k - 1))
        {
            Console.WriteLine($"Numarul {n} nu are {k} cifre.");
        }
        else
        {
            //Extragem cifra de pe pozitia k
            long cifraK = (absN / (long)Math.Pow(10, k - 1)) % 10;
            Console.WriteLine($"A{k}-a cifra a numarului {n} este: {cifraK}");
        }
       
    }
    
    }
