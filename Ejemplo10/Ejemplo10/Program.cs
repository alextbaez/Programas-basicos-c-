using System;
using System.Collections.Generic;

class EjemploListas
{
    static void Main()
    {
        int i, numero;
       

        // declaracion de lista llamada datos
        List<int> datos = new List<int>();
        int dia;
        string nombreDia;
        int posicion = -1;

        Console.Write("Dame datos y (-1) para terminar ");

        // Insertar datos en una lista
        do
        {
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero != -1)
            {
                datos.Add(numero);
            }
        } while (numero != -1);

        // Datos de la lista en orden nornmal
        Console.Write("Sus datos son: ");
        for (i = 0; i < datos.Count; i++)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();

        // Datos de la lista al reves
        Console.WriteLine("Sus datos al reves son: ");
        for (i = datos.Count-1; i >= 0; i--)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();

        // Busqueda en una lista
        Console.Write("Dime un numero: ");
        int datoBuscar = Convert.ToInt32(Console.ReadLine());

        // se identifica si la lista contiene el dato
        if (datos.Contains(datoBuscar))
        {
            Console.WriteLine("Encontrado");
        }
        else
        {
            Console.WriteLine("No encontrado");
        }
    }
}
