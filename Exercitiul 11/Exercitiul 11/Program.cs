using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Cifrele numarului sunt:");
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        //Separam nr.negative
        if (n < 0)
        {
            Console.WriteLine("-");
            n = -n;
        }

        while (n > 0)
        {
            int cifra = n % 10;
            Console.WriteLine(cifra);
            n /= 10;

        }
        Console.WriteLine();
    }
}