using System;

class PruebaWhile
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Dime 1er numero ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime 2do numero ");
        n2 = Convert.ToInt32(Console.ReadLine());

        while (n2 == 0)
        {
            Console.Write("No debe ser sero dime otro numero ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("La division es: ");
        Console.WriteLine(n1 / n2);
    }

}