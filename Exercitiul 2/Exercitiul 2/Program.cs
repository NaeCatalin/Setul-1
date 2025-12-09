using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti coeficientul a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Introduceti coeficientul b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Introduceti coeficientul c: ");
        double c = double.Parse(Console.ReadLine());

        // Cazul 1: a = 0 -> ecuatie de gradul 1 sau imposibila
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Ecuatie cu solutii infinite.");
                else
                    Console.WriteLine("Ecuatie imposibila. Nu exista solutii.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("Ecuatie de gradul 1. Solutia este: x = " + x);
            }
        }
        #region 1
        // => XizDD/RwE/vYlMBBDuK2LA== <=
        #endregion

        else
        {
            // Cazul 2: ecuatie de gradul 2
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Doua solutii reale distincte:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("O solutie reala dubla:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Nu exista solutii reale. Solutii complexe:");
                Console.WriteLine($"x1 = {real} + {imag}i");
                Console.WriteLine($"x2 = {real} - {imag}i");
            }
        }
    }
}
