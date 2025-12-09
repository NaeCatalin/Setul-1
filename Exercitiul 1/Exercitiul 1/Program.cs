using System;

class Program
{
    static void Main()
    {
        // Citirea valorilor a și b de la tastatură
        Console.Write("Introduceti valoarea lui a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceti valoarea lui b: ");
        double b = double.Parse(Console.ReadLine());

        // Verificarea cazului in care a este 0
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Ecuația are infinit de multe soluții.");
            }
            else
            {
                Console.WriteLine("Ecuația nu are soluție.");
            }
        }
        else
        {
            // Calcularea valorii lui x
            double x = -b / a;
            Console.WriteLine($"Soluția ecuației {a}x + {b} = 0 este x = {x}");
        }
    }
}
