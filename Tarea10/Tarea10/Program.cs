using System;
using System.Collections.Generic;

class TareaLista2
{
    static void Main()
    {
        List<int> numerosLista = new List<int>();
        int numero, i;
        bool terminar = false;

        // se inicia la solicitud de datos
        Console.WriteLine("Ingrese numeros para guardar");
        do
        {
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != -1)
            {
                //si el numero es diferente de -1 se guarda el numero
                numerosLista.Add(numero);
            }
            else if (numero == -1)
            {
                // si el numero es -1 se valida si se desea continuar guardando datos incluyendo el -1
                Console.WriteLine("Para terminar ingrese -1 otra vez sino presione 0");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                {
                    terminar = true;
                }
                else
                {
                    numerosLista.Add(-1);
                    Console.WriteLine("Siga ingresando numeros");
                }
            }

        } while (terminar == false);

        Console.WriteLine();

        // se verifica si en la lista esta contenido un numero introducido por el usuario
        Console.Write("Ingrese el valor guardado que desea verificar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numerosLista.Contains(numero))
        {
            Console.WriteLine("Valor encontrado");
        }
        else
        {
            Console.WriteLine("El valor no existe en la lista");
        }

        Console.WriteLine();

        // se muestran los datos que estan dentro de la lista
        Console.WriteLine("Los valores ingresados son: ");

        for (i = 0; i < numerosLista.Count; i++)
        {
            Console.Write(numerosLista[i] + " ");
        }
    }

}