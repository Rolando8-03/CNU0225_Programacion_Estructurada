using System;

class AnioNacimiento
{
    static void Main(string[] args)
    {
        int edad = LeerEdad();
        int anioNacimiento = CalcularAnioNacimiento(edad);

        Console.WriteLine($"\nTu año de nacimiento es: {anioNacimiento}");
        Console.ReadKey();
    }

    // Función para leer y validar la edad
    static int LeerEdad()
    {
        int edad;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese su edad: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out edad))
            {
                Console.WriteLine("Error: ingrese un número válido.\n");
                continue;
            }

            if (edad <= 0 || edad > 120)
            {
                Console.WriteLine("Error: ingrese una edad realista.\n");
                continue;
            }

            return edad;
        }
    }

    // Función para calcular el año de nacimiento
    static int CalcularAnioNacimiento(int edad)
    {
        int anioActual = DateTime.Now.Year;
        return anioActual - edad;
    }
}
