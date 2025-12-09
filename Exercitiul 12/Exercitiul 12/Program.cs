using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti b:");
        int b = int.Parse(Console.ReadLine());

        if(n == 0)
        {
            Console.WriteLine("Nu exista numere divizibile cu 0 ");
            return;
        }

        // Asiguram ca a este mai mic sau egal cu b
        if(a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int left =(int)Math.Ceiling(a / (double)n);
        int right = (int)Math.Floor(b / (double)n);

        int count = right - left + 1;
        if (count < 0)
        {
            count = 0;
        } 
        Console.WriteLine("Numarul de valori divizibile cu"   + n +
                            " in intervalul [" + a + ", " + b + "] este: " + count);


    }
}