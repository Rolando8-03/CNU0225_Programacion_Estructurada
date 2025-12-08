using System;

class GenerarContrasena
{
    static void Main(string[] args)
    {
        int longitud = LeerLongitud();
        string contrasena = CrearContrasena(longitud);

        Console.WriteLine($"\nContraseña generada: {contrasena}");
        Console.ReadKey();
    }

    // Función para leer y validar longitud
    static int LeerLongitud()
    {
        int longitud;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la longitud de la contraseña (mínimo 4): ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out longitud))
            {
                Console.WriteLine("Error: debe ingresar un número entero.\n");
                continue;
            }

            if (longitud < 4)
            {
                Console.WriteLine("Error: la longitud mínima es 4.\n");
                continue;
            }

            return longitud;
        }
    }

    // Función para generar contraseña
    static string CrearContrasena(int longitud)
    {
        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
        Random rnd = new Random();
        string contrasena = "";

        for (int i = 0; i < longitud; i++)
        {
            int index = rnd.Next(caracteres.Length);
            contrasena += caracteres[index];
        }

        return contrasena;
    }
}
