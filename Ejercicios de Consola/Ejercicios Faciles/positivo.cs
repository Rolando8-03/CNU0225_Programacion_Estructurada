using System;

class PositivoNegativo
{
    static void Main(string[] args)
    {
        double numero = LeerNumero();
        MostrarSigno(numero);

        Console.ReadKey();
    }

    // Función para leer y validar el número
    static double LeerNumero()
    {
        double numero;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return numero;
        }
    }

    // Función para mostrar si el número es positivo, negativo o cero
    static void MostrarSigno(double num)
    {
        if (num > 0)
        {
            Console.WriteLine($"\nEl número {num} es POSITIVO.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"\nEl número {num} es NEGATIVO.");
        }
        else
        {
            Console.WriteLine("\nEl número es CERO.");
        }
    }
}
