using System;

class TareaCondiciones
{

    static void Main()
    {
        //Tarea acceso

        Console.Write("Digite su nombre: ");
        string nombre = Console.ReadLine();

        if (nombre == "Alext")
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }

        //Tarea division en caso de que el segundo # no sea 0

        int numero1, numero2;

        Console.Write("Ingrese el 1er numero entero ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el 2do numero entero ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero2 != 0)
        {
            Console.Write("la division entre ambos numero es: ");
            Console.WriteLine(numero1 / numero2);
        }
        else 
        {
            Console.WriteLine("No se puede dividir el 2do numero es 0");
        }

        // Tarea cantidad de positivos

        Console.Write("Ingrese el 1er numero entero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el 2do numero entero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        if ((numero1 == 0) && (numero2 == 0))
        {
            Console.WriteLine("Ambos numeros son 0");
        }
        else if ((numero1 == 0) || (numero2 == 0))
        {
            Console.WriteLine("Uno de los numeros es 0");
        }
        else if ((numero1 > 0) && (numero2 > 0))
        {
            Console.WriteLine("Los dos son positivos");
        }
        else if ((numero1 > 0) && (numero2 < 0))
        {
            Console.WriteLine("Solo el 1er numero es mayor que cero");
        }
        else if ((numero1 < 0) && (numero2 > 0))
        {
            Console.WriteLine("Solo el 2do numero es mayor que cero");
        }
        
   

    }

}
