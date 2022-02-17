using System;
using System.Collections.Generic;

class TareaListas
{
    static void Main()
    {
        List<string> listaTextos = new List<string>();
        string texto;
        int accion = 0, i;
      

        Console.WriteLine("Ingrese cualquier texto (-1) para terminar");
        do
        {
            texto = Console.ReadLine();

            if (texto == "-1")
            {
                accion = -1;
            }

            if (accion != -1 )
            {
                listaTextos.Add(texto);
            }


        } while (accion != -1);

        Console.WriteLine("Desea ver los datos (s o n)");
        texto = Console.ReadLine();

        if (texto == "s")
        {
            for (i = listaTextos.Count - 1; i >= 0 ; i--)
            {
                Console.Write(listaTextos[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("gracias por los datos, estaban ricos");
        }


    }

}
