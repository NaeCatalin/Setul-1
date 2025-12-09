using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti anul y1: ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti anul y2: ");
        int y2 = int.Parse(Console.ReadLine());

        // Asiguram y1 <= y2
        if (y1 > y2)
        {
            int temp = y1;
            y1 = y2;
            y2 = temp;
        }

        int count = 0;

        for (int y = y1; y <= y2; y++)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                count++;
            }
        }

        Console.WriteLine("Numarul de ani bisecti intre " + y1 + " si " + y2 + " este: " + count);
    }
}
