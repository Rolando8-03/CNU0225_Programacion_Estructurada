using System;

class ConversionDolaresEuros
{
    const double TS = 1.25;

    static void Main(string[] args)
    {
        double dolares = LeerDolares();
        double euros = ConvertirAEuros(dolares);

        Console.WriteLine($"\n{dolares} dólares equivalen a {euros} euros.");
        Console.ReadKey();
    }

    // Función para leer y validar los dólares
    static double LeerDolares()
    {
        double dolares;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la cantidad en dólares: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out dolares))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            if (dolares < 0)
            {
                Console.WriteLine("Error: No se permiten valores negativos.\n");
                continue;
            }

            return dolares;
        }
    }

    // Función para convertir dólares a euros
    static double ConvertirAEuros(double dolares)
    {
        return dolares / TS;
    }
}
