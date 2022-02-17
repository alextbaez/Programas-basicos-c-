using System;

class PruebaDeIf
{
    static void Main()
    {
 
        Console.Write("Dime un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if ( n > 0 )
        {
            Console.WriteLine("Es positivo");
        }
        else
        {
            Console.WriteLine("Es negativo o cero");
        }

        if (n < 0)
        {
            Console.WriteLine("Es negativo");
        }


        // >= mayor o igual
        // >= menor o igual
        // == igual a
        // != distinto a

        if (n == 5)
        {
            Console.WriteLine("Es cinco");
        }

        if (n != 3)
        {
            Console.WriteLine("No es un tres");
        }

        // && y
        // || o
        // ! no

        if ((n > 0) && (n % 2 == 0))
        {
            Console.WriteLine("Es positivo y par");
        }

        if ((n == 2) || (n == 3))
        {
            Console.WriteLine("Es dos o tres");
        }

        if (! (n < 0))
        {
            Console.WriteLine("No es negativo");
        }

        if (n == 2)
        {
            Console.WriteLine("Es dos");
        }
        else if (n == 3)
        {
            Console.WriteLine("Es tres");
        }
        else if (n == 4)
        {
            Console.WriteLine("Es 4");
        }
        else
        {
            Console.WriteLine("No esta entre el 2 y el 4");
        }

        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();

        if (nombre == "Nacho")
        {
            Console.WriteLine("Hola");
        }

    }

}
