using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti valoarea lui a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti valoarea lui b:");
        int b = int.Parse(Console.ReadLine());

        //Shimbarea fara variabila auxiliara
        a= a + b;
        b= a - b;
        a= a - b;

        Console.WriteLine("Dupa schimbare:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}