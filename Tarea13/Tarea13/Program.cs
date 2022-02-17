using System;

class TareaFuncionesValor
{
    static void Main()
    {
        // Tarea devolver el triple de un numero a traves de una funcion
        double num;
        Console.Write("Ingrese un valor para la funcion triple: ");
        num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("El triple de su numero es: " + Triple(num));

        // Tarea devolver el mayor de dos numeros
        int n1, n2;
        Console.WriteLine("Ingrese el 1er numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el 2do numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (Mayor(n1, n2) == 0)
        {
            Console.WriteLine("Los numeros son iguales");
        }
        else
        {
            Console.WriteLine("El valor mayor es: " + Mayor(n1, n2));
        }

        // Tarea funcion buscar con array
        int i, numero, cantidadNumeros = 0;
        int[] numeros;

        Console.Write("Ingrese la cantidad de datos que desea guardar: ");
        cantidadNumeros = Convert.ToInt32(Console.ReadLine());
        numeros = new int[cantidadNumeros];

        Console.WriteLine("Ingrese " + cantidadNumeros + " Numeros");
        for (i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("ingrese el valor que desea identificar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (Buscar(numeros, numero) == -1)
        {
            Console.WriteLine("el numero no existe dentro del array");
        }
        else
        {
            Console.WriteLine("Su numero esta en la posicion: " + Buscar(numeros, numero));
        }

    }

    static double Triple(double n)
    {
        return n * 3;
    }

    static int Mayor(int n1, int n2)
    {
        int NumMayor;
        if (n1 == n2)
        {
            NumMayor = 0;
        }
        else if(n1 > n2)
        {
            NumMayor = n1;
        }
        else
        {
            NumMayor = n2;
        }

        return NumMayor;
    }

    static int Buscar(int[] NumerosArray, int num )
    {
        int i;
        int posicion = -1;

        for (i = 0; i < NumerosArray.Length; i++)
        {
            if (num == NumerosArray[i])
            {
                posicion = i + 1;
            }
        }

        return posicion;
    }
}
