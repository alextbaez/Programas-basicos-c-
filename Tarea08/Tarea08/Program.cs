using System;

class TareaArray
{
    static void Main()
    {
        double[] numeros = new double[10];
        int i;

        // Tarea ingresar 10 numeros reales y mostrarlos en el orden inverso
        //Console.WriteLine("Ingrese 10 numeros: ");

        //for (i = 0; i < numeros.Length; i++)
        //{
        //    numeros[i] = Convert.ToDouble(Console.ReadLine());
        //}

        //Console.WriteLine("Los numeros al reves son: ");

        //for (i = 9; i >= 0; i--)
        //{
        //    Console.Write(numeros[i] + " ");
        //}
        //Console.WriteLine();

        // Mostrar nombre de mes desde un array segun el numero de mes dado por el usuario
        int numeroMes;
        string nombreMes;
        string[] meses = {"enero", "febrero", "marzo", "abril", 
            "mayo", "junio", "julio", "agosto", "septiembre", 
            "octubre", "noviembre", "diciembre" };

        //Console.Write("Ingrese el numero del mes: ");

        //do
        //{
        //    numeroMes = Convert.ToInt32(Console.ReadLine());
        //    if (((numeroMes) > meses.Length) || ((numeroMes - 1) < 0))
        //    {
        //        Console.WriteLine("Este mes no existe ingrese otro");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Su mes es: " + meses[numeroMes - 1]);
        //    }
        //} while (((numeroMes) > meses.Length) || ((numeroMes - 1) < 0));

        //Console.WriteLine();

        // Numero del mes de acuerdo a su nombre

        int posicion = -1;
        Console.Write("Ingrese el nombre del mes en minusculas: ");
        nombreMes = Console.ReadLine();

        do
        {
            for (i = 0; i < meses.Length; i++)
            {
                if (nombreMes == meses[i])
                {
                    posicion = i + 1;
                    Console.WriteLine("Su mes es el: " + posicion);
                }
                
            }
            if (posicion == -1)
            {
                Console.Write("Error ingrese un mes valido ");
                nombreMes = Console.ReadLine();
            }
           
        } while (posicion == -1);
        
      


    }
}
