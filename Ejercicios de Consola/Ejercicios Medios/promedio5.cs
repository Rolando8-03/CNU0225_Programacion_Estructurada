using System;

class PromedioCincoNumeros
{
    static void Main(string[] args)
    {
        double promedio = CalcularPromedio();
        Console.WriteLine($"\nEl promedio de los 5 números es: {promedio}");
        Console.ReadKey();
    }

    // Función que lee y valida un número
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

    // Función que calcula el promedio de 5 números
    static double CalcularPromedio()
    {
        double suma = 0;

        for (int i = 1; i <= 5; i++)
        {
            double numero = LeerNumero($"Ingrese el número {i}: ");
            suma += numero;
        }

        return suma / 5;
    }
}
