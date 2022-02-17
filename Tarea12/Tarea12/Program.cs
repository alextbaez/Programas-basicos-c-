using System;

class TareaFuncionesVoid2
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Ingrese a");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese b");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese c");
        c = Convert.ToDouble(Console.ReadLine());

        ResolverSegundoGrado(a, b, c);
    }

    static void ResolverSegundoGrado(double a, double b, double c)
    {
        List<double> respuestas = new List<double>();
        double x;
        double n = (b * b) - (4 * a * c);
        int i = 0;

        Console.WriteLine("el valor de n es: " + n);

        // se comprueba si tiene dos soluciones
        if (n > 0)
        {
            x = (-b + Math.Sqrt(n)) / (2 * a);
            respuestas.Add(x);

            x = (-b - Math.Sqrt(n)) / (2 * a);
            respuestas.Add(x);

            Console.Write("Sus respuestas son: ");
            for (i = 0; i < respuestas.Count; i++)
            {
                Console.Write(respuestas[i] + " ");
            }
        }
        // se comprueba si solo tiene una solucion
        else if(n == 0)
        {
            x = (-b + Math.Sqrt(n)) / (2 * a);
            respuestas.Add(x);

            Console.Write("Debido a que el valor dentro de la raiz es 0 su respuesta es: ");
            Console.WriteLine(respuestas[i]);
        }
        // sino se cumplen ninguna de las condiciones entonces no tiene solucion
        else
        {
            Console.WriteLine("No existe respuesta");
        }


       
    }
}
