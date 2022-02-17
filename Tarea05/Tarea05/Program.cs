using System;

class TareaWhile
{
    static void Main()
    {
        string clave;
        Console.Write("Para poder ingresar digite su codigo de acceso: ");
        clave = Console.ReadLine();

        // se comprueba si la clave es distinta a la correcta de ser asi se mantiene en el bloque de codigo
        while (clave != "1234")
        {
            Console.Write("Codigo incorrecto, ingrese el codigo nuevamente: ");
            clave = Console.ReadLine();
        }

        Console.WriteLine("Acceso permitido");
    }
}
