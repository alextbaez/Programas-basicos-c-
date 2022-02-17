using System;

class Ejemplo03 
{
    static void Main()
    {
        string nombre;
        int numero1, numero2;
        double numero3, numero4;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Bienvenido, ");
        Console.WriteLine(nombre);


        Console.Write("Numero real 1: ");
        numero3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Numero real 2: ");
        numero4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("La division de los reales es: ");
        Console.WriteLine(numero3 / numero4);

        Console.Write("Numero entero 1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Numero entero 2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("La division de los enteros es: ");
        Console.WriteLine(numero1 / numero2);

        Console.Write("El resto de la division es: ");
        Console.WriteLine(numero1 % numero2);

    }

}
