using System;

class EjemploFuncionVoid
{
    static void Main()
    {
        Felicitar("Juan");

        Felicitar("Pedro");

        Felicitar("Alex");


    }

    static void Felicitar(string nombre)
    {
        Console.WriteLine("Felicitaciones lo estas haciendo bien " + nombre);
    }
}
