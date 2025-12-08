using System;

class CelsiusAFahrenheit
{
    static void Main(string[] args)
    {
        double celsius = LeerNumero("Ingrese los grados Celsius: ");
        double fahrenheit = ConvertirCelsiusAFahrenheit(celsius);

        Console.WriteLine($"\n{celsius} °C equivalen a {fahrenheit} °F");
        Console.ReadKey();
    }

    // Función para leer y validar un número
    static double LeerNumero(string mensaje)
    {
        double num;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out num))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.\n");
                continue;
            }

            return num;
        }
    }

    // Función para convertir Celsius a Fahrenheit
    static double ConvertirCelsiusAFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
