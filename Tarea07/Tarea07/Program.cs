using System;

class TareaBucleFor
{
    static void Main()
    {
        int i;
        // Numeros del 10 al 20
        for (i = 10; i <= 20; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // numeros del 15 al 10
        for (i = 15; i >= 10; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // multiplos de 3
        for (i = 3; i <= 30; i += 3)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();


        for (i = 0; i <= 10; i++)
        {
            Console.Write("Hola ");
        }
        Console.WriteLine();
    }
}
