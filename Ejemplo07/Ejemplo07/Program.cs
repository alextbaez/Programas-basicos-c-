using System;

class EjemploDoWhile
{
    static void Main()
    {
        int n1, n2;
        Console.WriteLine("1er Numero entero: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("2do Numero entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("No debe ser 0");
            }
        }
        while (n2 == 0);

        Console.WriteLine("La division es: ");
        Console.WriteLine(n1 / n2);
    }
}
