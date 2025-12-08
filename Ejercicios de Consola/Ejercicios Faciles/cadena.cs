using System;

class CadenaMayorCinco
{
    static void Main(string[] args)
    {
        string texto = LeerCadena("Ingrese una cadena de texto: ");
        VerificarLongitud(texto);

        Console.ReadKey();
    }

    // Función para leer la cadena
    static string LeerCadena(string mensaje)
    {
        string cadena;

        while (true)
        {
            Console.Write(mensaje);
            cadena = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cadena))
            {
                Console.WriteLine("Error: La cadena no puede estar vacía.\n");
                continue;
            }

            return cadena;
        }
    }

    // Función para verificar si tiene más de 5 caracteres
    static void VerificarLongitud(string cadena)
    {
        if (cadena.Length > 5)
        {
            Console.WriteLine("\nLa cadena tiene más de 5 caracteres.");
        }
        else
        {
            Console.WriteLine("\nLa cadena NO tiene más de 5 caracteres.");
        }
    }
}
