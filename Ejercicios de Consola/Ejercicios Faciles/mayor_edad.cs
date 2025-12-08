using System;

class MayorDeEdad
{
    static void Main(string[] args)
    {
        int edad = LeerEdad();
        EsMayorDeEdad(edad);

        Console.ReadKey();
    }

    // Función para leer y validar la edad
    static int LeerEdad()
    {
        int edad;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la edad: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out edad))
            {
                Console.WriteLine("Error: debe ingresar un número entero.\n");
                continue;
            }

            if (edad < 0)
            {
                Console.WriteLine("Error: la edad no puede ser negativa.\n");
                continue;
            }

            return edad;
        }
    }

    // Función para determinar si es mayor o menor de edad
    static void EsMayorDeEdad(int edad)
    {
        if (edad >= 18)
        {
            Console.WriteLine("\nLa persona es MAYOR de edad.");
        }
        else
        {
            Console.WriteLine("\nLa persona es MENOR de edad.");
        }
    }
}
