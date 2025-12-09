using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul n");
        int n = int.Parse(Console.ReadLine());

        if (n <2 )
        {
            Console.WriteLine("Numarul NU este prim.");
            return;
        }
        bool estePrim = true;
        for(int i = 2; i*i <= n; i++)
        {
            if (n % i ==0)
            {
                estePrim = false;
                break;
            }
        }
        if (estePrim)
            Console.WriteLine("Numarul este prim");
        else
            Console.WriteLine("Numarul NU este prim");
    }
}