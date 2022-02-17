using System;

class PruebaSwitch 
{
    static void Main()
    {
        Console.Write("Dime un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 2:
                Console.WriteLine("Es un dos");
            break;

            case 3:
                Console.WriteLine("Es un tres");
                break;

            case 4:
                Console.WriteLine("Es un 4");
            break;

            default:
                Console.WriteLine("No esta entre el 2 y el 4");
            break;
        }

        Console.WriteLine("Dime el numero de un dia de la semana (1 a 7)");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("Lunes");     break;
            case 2: Console.WriteLine("Martes");    break;
            case 3: Console.WriteLine("Miercoles"); break;
            case 4: Console.WriteLine("Jueves");    break;
            case 5: Console.WriteLine("Viernes");   break;
            case 6: Console.WriteLine("Sabadp");    break;
            case 7: Console.WriteLine("Domingo");   break;

            default: Console.WriteLine("Este dia no existe"); break;
        }
    }

}
