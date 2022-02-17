using System;

class TareaDoWhile
{
    static void Main()
    {
        
        string user_Name, password;

        // Prueba de do while con clave de acceso
        do
        {
            Console.Write("Ingrese su clave de acceso: ");
            password = Console.ReadLine();

            if (password != "1234")
            {
                Console.WriteLine("Clave incorrecta");
            }
            else
            {
                Console.WriteLine("Acceso Permitido");
            }
        } while (password != "1234");

        // Prueba de do while con usuario y clave de acceso
        do
        {
            Console.Write("Ingrese su usuario de acceso: ");
            user_Name = Console.ReadLine();

            Console.Write("Ingrese su clave de acceso: ");
            password = Console.ReadLine();

            if ((user_Name != "Alext") || (password != "1234"))
            {
                Console.WriteLine("Usuario o contrasena incorrectos");
            }
            else
            {
                Console.WriteLine("Acceso permitido");
            }

        } while ((user_Name != "Alext") || (password != "1234"));
    }
}
