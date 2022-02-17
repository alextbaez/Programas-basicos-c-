using System;

class BucleFor
{
    static void Main(string[] args)
    {
        int i;
        for (i = 1; i <= 10; i = i + 1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (i = 10; i >= 1; i = i - 1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (i = 1; i <= 5; i = i + 1)
        {
            Console.Write("hola ");
        }

        Console.WriteLine();

        for (i = 1; i <= 3; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (i = 4; i <= 10; i = i + 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (i = 5; i <= 25; i += 5)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

    }
}
