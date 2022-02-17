using System;

class EjemploArrays
{
    static void Main()
    {
        int[] datos = new int[5];
        int i, dia;
        string nombreDia;

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Los datos son: ");

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(datos[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("los datos al reves son: ");
        for (i = 4; i >= 0 ; i--)
        {
            Console.WriteLine(datos[i] + " ");
        }

        string[] diasDeSemana = { "Lunes", "Martes", "Miercoles", "Jueves", 
            "Viernes", "Sabado", "Domingo" };

        Console.Write("dime un numero de dia ");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El nombre del dia es " + diasDeSemana[dia - 1]);

        Console.Write("Ingrese el nombre del dia ");
        nombreDia = Console.ReadLine();

        // variable para indicar en que posicion se encontro o para lanzar mensaje en caso de no encontrarse
        int posicion = -1;
        for (i = 0; i < diasDeSemana.Length; i++)
        {
            if (nombreDia == diasDeSemana[i])
            {
                posicion = i + 1;
            }
        }

        if (posicion == -1)
        {
            Console.WriteLine("Dia no encontrado");
        }
        else
        {
            Console.WriteLine("Encontrado en " + posicion);
        }
        

    }

}