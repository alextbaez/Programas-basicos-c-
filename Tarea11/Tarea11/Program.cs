using System;

class TareaFuncionesVoid
{
    static void Main()
    {
        int quantity;

        Console.WriteLine("Ingrese cuantos asteriscos quiere mostrar: ");
        quantity = Convert.ToInt32(Console.ReadLine());
        EscribirAsteriscos(quantity);
        Console.WriteLine();
    }

    // funcion que escribe la cantidad de asteriscos dependiendo de el numero que recibe por parametro
    static void EscribirAsteriscos(int CantAsteriscos)
    {
        for (int i = 0; i < CantAsteriscos; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
