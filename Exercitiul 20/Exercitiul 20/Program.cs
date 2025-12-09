using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Citim numaratorul si numitorul
        Console.WriteLine("Introduceti numaratorul m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti numitorul n:");
        int n = int.Parse(Console.ReadLine());

        // Afisam partea intreaga
        int parteaIntreaga = m / n;
        Console.Write(parteaIntreaga + ".");

        int rest = m % n;
        if (rest == 0)
        {
            Console.WriteLine("0");
            return;
        }

        // Dictionar pentru a tine resturile si pozitia lor in rezultat
        Dictionary<int, int> resturi = new Dictionary<int, int>();
        string zecimale = "";
        int pozitie = 0;
        int startPerioada = -1;

        while (rest != 0)
        {
            if (resturi.ContainsKey(rest))
            {
                startPerioada = resturi[rest];
                break;
            }

            resturi[rest] = pozitie;
            rest *= 10;
            int cifra = rest / n;
            zecimale += cifra;
            rest %= n;
            pozitie++;
        }

        if (startPerioada == -1)
        {
            // fractie neperiodica
            Console.WriteLine(zecimale);
        }
        else
        {
            // fractie periodica
            string nonPeriodica = zecimale.Substring(0, startPerioada);
            string periodica = zecimale.Substring(startPerioada);
            Console.WriteLine(nonPeriodica + "(" + periodica + ")");
        }
    }
}
