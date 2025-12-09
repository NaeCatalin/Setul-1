using System;

class Program
{
    #region 3
    // => qtXaXAniN10YHyxZQJDqCw== <=
    #endregion

    static void Main()
    {
        Console.Write("Introduceti n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti k: ");
        int k = int.Parse(Console.ReadLine());

        if (k == 0)
        {
            Console.WriteLine("Impartirea la zero nu este permisa.");
        }
        else
        {
            if (n % k == 0)
                Console.WriteLine("n se divide cu k.");
            else
                Console.WriteLine("n NU se divide cu k.");
        }
    }
}
