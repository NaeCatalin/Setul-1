using System;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main ()
    {
        Console.WriteLine("Introduceti nr n");
        int n;
        while(true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out n ))
            {
                break;
            }
        }

        #region
        //
        #endregion
        Console.WriteLine("Divizorii lui " + n + " sunt:");
        for (int i = 1; i<= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i + " ");
            }
        }

        Console.WriteLine();

    }
}