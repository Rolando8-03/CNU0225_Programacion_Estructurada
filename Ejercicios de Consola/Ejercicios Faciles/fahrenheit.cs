using System;

class FahrenheitACelsius
{
    static void Main(string[] args)
    {
        double f = LeerNumero("Ingrese la temperatura en Fahrenheit: ");
        double c = Convertir(f);

        Console.WriteLine($"\nCelsius: {c}");
        Console.ReadKey();
    }

    static double LeerNumero(string msg)
    {
        double num;
        while (true)
        {
            Console.Write(msg);
            if (double.TryParse(Console.ReadLine(), out num))
                return num;

            Console.WriteLine("Error: ingrese un valor válido.\n");
        }
    }

    static double Convertir(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
