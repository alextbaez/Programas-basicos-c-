using System;

class TareaSwitch
{
    static void Main()
    {
        
        Console.Write("Ingrese el numero del mes (1 - 12) ");
        int Numero_Mes = Convert.ToInt32(Console.ReadLine());

        // Nombre del mes segun el numero de dicho mes
        switch (Numero_Mes)
        {
            case 1: Console.WriteLine("Enero");         break;
            case 2: Console.WriteLine("Febrero");       break;
            case 3: Console.WriteLine("Marzo");         break;
            case 4: Console.WriteLine("Abril");         break;
            case 5: Console.WriteLine("Mayo");          break;
            case 6: Console.WriteLine("Junio");         break;
            case 7: Console.WriteLine("Julio");         break;
            case 8: Console.WriteLine("Agosto");        break;
            case 9: Console.WriteLine("Septiembre");    break;
            case 10: Console.WriteLine("Octubre");      break;
            case 11: Console.WriteLine("Noviembre");    break;
            case 12: Console.WriteLine("Diciembre");    break;

            default:
                Console.WriteLine("Este mes no existe");
            break;
        }

        Console.Write("Ingrese el nombre del mes en minusculas ");
        string Nombre_Mes = Console.ReadLine();

        // Cantidad de dias segun el nombre del mes
        switch (Nombre_Mes)
        {

            case "enero": Console.WriteLine("31 dias");         break;
            case "febrero": Console.WriteLine("28 dias");       break;
            case "marzo": Console.WriteLine("31 dias");         break;
            case "abril": Console.WriteLine("30 dias");         break;
            case "mayo": Console.WriteLine("31 dias");          break;
            case "junio": Console.WriteLine("30 dias");         break;
            case "julio": Console.WriteLine("31 dias");         break;
            case "agosto": Console.WriteLine("30 dias");        break;
            case "septiembre": Console.WriteLine("30 dias");    break;
            case "octubre": Console.WriteLine("31 dias");       break;
            case "noviembre": Console.WriteLine("30 dias");     break;
            case "diciembre": Console.WriteLine("31 dias");     break;

            default:
                Console.WriteLine("Este mes no existe");
            break;
        }
    }
}
